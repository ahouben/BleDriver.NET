#
# Copyright (c) 2012 Alexander Houben (ahouben@greenliff.com)
#
# Permission is hereby granted, free of charge, to any person obtaining a copy of
# this software and associated documentation files (the "Software"), to deal in
# the Software without restriction, including without limitation the rights to
# use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
# of the Software, and to permit persons to whom the Software is furnished to do
# so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in all
# copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
# IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
# AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
# LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
# OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
# SOFTWARE.

import os, sys
import xml.dom.minidom

typeMap = {
    'uint8' : ['int', 1],
    'int8' : ['int', 1],
    'uint16' : ['int', 2],
    'uint32' : ['int', 4],
    'int16' : ['int', 2],
    'uint8array' : ['byte[]', 0],
    'bd_addr' : ['bd_addr', 0],
}

class BgApiParam(object):
    def parse(self, node, prefix):
        self.datatype = node.getAttribute('datatype')
        self.name = '%s%s' % (prefix, node.getAttribute('name'))
        self.type = node.getAttribute('type')
    def dump(self):
        return '%s %s' % (typeMap[self.type][0], self.name)

class BgApiEnum(object):
    def __init__(self, upper):
        self.upper = upper
    def parse(self, node):
        self.name = node.getAttribute('name')
        self.values = []
        for valueNode in node.getElementsByTagName('enum'):
            self.values.append([valueNode.getAttribute('name'), valueNode.getAttribute('value')])

class BgApiCommandEvent(object):
    def __init__(self, upper, isEvent=False):
        self.upper = upper
        self.isEvent = isEvent
    
    def parse(self, node):
        self.index = node.getAttribute('index')
        self.name = node.getAttribute('name')
        self.no_return = node.getAttribute('no_return') or 'false'
        self.internal = node.getAttribute('internal') or 'false'
        self.script = node.getAttribute('script')
        
        self.params = self.param(node.getElementsByTagName('params'))
        self.returns = self.param(node.getElementsByTagName('returns'))
        
    def param(self, node, prefix = ''):
        if len(node) == 0:
            return []
        params = []
        for p in node[0].getElementsByTagName('param'):
            parm = BgApiParam()
            parm.parse(p, prefix)
            params.append(parm)
        return params
    def return_struct(self):
        return (self.returns and self.struct()) or 'void'
    def struct(self):
        return 'ble_msg_%s_%s_%s_t' % (self.upper.name, self.name, (self.isEvent and 'evt') or 'rsp')
    def return_struct_declaration(self):
        if not self.returns and not self.isEvent:
            return ''
        s = '''
        public class %(struct)s : ble_event
        {%(body)s
        }
''' % { 'struct' : (self.isEvent and self.struct()) or self.return_struct(), 'body' : self.return_struct_declaration_body() }
        return s
    def return_struct_declaration_body(self):
        s = ''
        for r in (self.isEvent and self.params) or self.returns:
            s += '''
            public %(param)s;''' % { 'param' : r.dump() }
        return s
    def dump(self, f):
        in_params = self.dumpInParams()
        f.write('''
        %(modifier)s %(virtual)s%(return)s %(method_name)s(%(in_params)s)
        {%(body)s
        }
''' % {
        'modifier' : (self.isEvent and 'protected') or 'public',
        'virtual' : (self.isEvent and 'virtual ') or '',
        'return' : (self.isEvent and 'void') or self.return_struct(),
        'class' : self.upper.name,
        'name' : self.name,
        'in_params' : (self.isEvent and '%s arg' % self.struct()) or in_params,
        'body' : (not self.isEvent and self.dumpBody()) or '''
            log("%s");''' % self.method_name(),
        'cmd' : (self.isEvent and 'evt') or 'cmd',
        'method_name' : self.method_name(),
    })
    
    def cmdLength(self):
        size = '0'
        for p in self.params:
            if typeMap[p.type][1] <> 0:
                size += ' + %s' % typeMap[p.type][1]
            else:
                size += ' + 1 + %s.Length' % p.name
        return size
    
    def dumpEventBody(self):
        s = ''
        for p in self.params:
            if typeMap[p.type][1] == 1:
                s += '''
                                s.%(name)s = buffer[idx++];''' % { 'name' : p.name }
            elif typeMap[p.type][1] == 2:
                s += '''
                                s.%(name)s = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;''' % { 'name' : p.name }
            elif typeMap[p.type][1] == 4:
                s += '''
                                s.%(name)s = buffer[idx+0] | (buffer[idx+1] << 8) | (buffer[idx+2] << 16) | (buffer[idx+3] << 24); idx+=4;''' % { 'name' : p.name }
            elif typeMap[p.type][0] == 'byte[]':
                s += '''
                                s.%(name)s = new byte[buffer[idx++]];
                                for(int i = 0; i < s.%(name)s.Length; i++)
                                {
                                    s.%(name)s[i] = buffer[idx++];
                                }''' % { 'name' : p.name }
            elif typeMap[p.type][0] == 'bd_addr':
                s += '''
                                s.%(name)s = new bd_addr();
                                for(int i = 0; i < s.%(name)s.Length; i++)
                                {
                                    s.%(name)s.Address[i] = buffer[idx++];
                                }''' % { 'name' : p.name }
        return s
    
    def method_name(self):
        return 'ble_%(type)s_%(class)s_%(name)s' % { 'type' : (self.isEvent and 'evt') or 'cmd', 'class' : self.upper.name, 'name' : self.name }
    def id(self):
        return self.method_name() + '_id'
    
    def dumpBody(self):
        s = '''
            log("%(id)s");
            byte[] _data = new byte[SIZE_HEADER + %(data_len)s];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_%(msg_type)s|0x0;
            _data[idx++] = (byte)(%(data_len)s);
            _data[idx++] = (byte)ble_classes.ble_cls_%(class)s;
            _data[idx++] = (byte)ble_command_ids.%(id)s;''' % { 'msg_type' : 'cmd', 'data_len' : self.cmdLength(), 'class' : self.upper.name, 'name' : self.name, 'id' : self.id() }
        idx = 4
        if self.params:
            s += '''
            // data'''
            for p in self.params:
                if typeMap[p.type][1] == 1:
                    s += '''
            _data[idx++] = (byte)%(name)s;''' % { 'name' : p.name }
                elif typeMap[p.type][1] == 2:
                    s += '''
            _data[idx++] = (byte)%(name)s;
            _data[idx++] = (byte)(%(name)s >> 8);''' % { 'name' : p.name }
                elif typeMap[p.type][1] == 4:
                    s += '''
            _data[idx++] = (byte)%(name)s;
            _data[idx++] = (byte)(%(name)s >> 8);
            _data[idx++] = (byte)(%(name)s >> 16);
            _data[idx++] = (byte)(%(name)s >> 24);''' % { 'name' : p.name }
                elif typeMap[p.type][0] == 'byte[]':
                    s += '''
            _data[idx++] = (byte)(%(name)s.Length);
            for(int i = 0; i < %(name)s.Length; i++)
            {
                _data[idx++] = %(name)s[i];
            }''' % { 'name' : p.name }
                elif typeMap[p.type][0] == 'bd_addr':
                    s += '''
            for(int i = 0; i < %(name)s.Length; i++)
            {
                _data[idx++] = %(name)s.Address[i];
            }''' % { 'name' : p.name }
        s += '''
            // send
            byte[] answer = Send(_data, 0, SIZE_HEADER /* header */ + %s, %s);''' % (self.cmdLength(), self.no_return)
        if self.returns:
            s += '''
            // parse answer
            idx = SIZE_HEADER;
            %(struct)s res = new %(struct)s();''' % { 'struct' : self.return_struct() }
            for p in self.returns:
                if typeMap[p.type][1] == 1:
                    s += '''
            res.%(name)s = answer[idx++];''' % { 'name' : p.name }
                elif typeMap[p.type][1] == 2:
                    s += '''
            res.%(name)s = answer[idx+0] | (answer[idx+1] << 8); idx+=2;''' % { 'name' : p.name }
                elif typeMap[p.type][1] == 4:
                    s += '''
            res.%(name)s = answer[idx+0] | (answer[idx+1] << 8) | (answer[idx+2] << 16) | (answer[idx+3] << 24); idx+=4;''' % { 'name' : p.name }
                elif typeMap[p.type][0] == 'byte[]':
                    s += '''
            res.%(name)s = new byte[answer[idx++]];
            for(int i = 0; i < res.%(name)s.Length; i++)
            {
                res.%(name)s[i] = answer[idx++];
            }''' % { 'name' : p.name }
                elif typeMap[p.type][0] == 'bd_addr':
                    s += '''
            res.%(name)s = new bd_addr();
            for(int i = 0; i < res.%(name)s.Length; i++)
            {
                res.%(name)s.Address[i] = answer[idx++];
            }''' % { 'name' : p.name }
            s += '''
            return res;'''
        return s
    
    def dumpInParams(self):
        params = []
        for p in self.params:
            params.append(p.dump())
        return ', '.join(params)
    def dumpOutParams(self):
        if not self.returns:
            return ''
        returns = []
        for r in self.returns:
            returns.append(r.dump())
        return ', '.join(returns)

class BgApiClass(object):
    def parse(self, node):
        self.index = node.getAttribute('index')
        self.name = node.getAttribute('name')
        self.singleton = node.getAttribute('singleton')
        self.commands = []
        for cmdNode in node.getElementsByTagName('command'):
            cmd = BgApiCommandEvent(self)
            cmd.parse(cmdNode)
            self.commands.append(cmd)
        self.events = []
        for evtNode in node.getElementsByTagName('event'):
            evt = BgApiCommandEvent(self, isEvent = True)
            evt.parse(evtNode)
            self.events.append(evt)
        self.enums = []
        for enumNode in node.getElementsByTagName('enums'):
            enum = BgApiEnum(self)
            enum.parse(enumNode)
            self.enums.append(enum)
        self.defines = []
        for defineNode in node.getElementsByTagName('defines'):
            enum = BgApiEnum(self)
            enum.parse(defineNode)
            self.defines.append(enum)
    def dump(self, f, dumpCommands):
        for cmd in (dumpCommands and self.commands) or self.events:
            cmd.dump(f)

class BgApi(object):
    def __init__(self):
        self.classes = []
    def parse(self, node):
        for classNode in node.getElementsByTagName('class'):
            cls = BgApiClass()
            cls.parse(classNode)
            self.classes.append(cls)
    def dump(self, out_cs):
        f = open(out_cs, 'wb')
        f.write('''/*
 * Copyright (c) 2012 Alexander Houben (ahouben@greenliff.com)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do
 * so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
// Auto-generated, do not modify
using System;

namespace BleDriver {
    public partial class BLE112 {
''')
        self.dumpClassEnum(f)
        self.dumpCommandsEnum(f)
        self.dumpEventsEnum(f)
        self.dumpEnumsEnum(f)
        self.dumpDefines(f)
        for dumpCommands in [True, False]:
            for cls in self.classes:            
                for cmd in (dumpCommands and cls.commands) or cls.events:
                    s = cmd.return_struct_declaration()
                    f.write(s)
#            f.write('''
#        #region %(type)s
#''' % { 'type' : (dumpCommands and 'Commands') or 'Events' })
            for cls in self.classes:
                cls.dump(f, dumpCommands)
#            f.write('''
#        #endregion %(type)s
#    }
#}
#''' % { 'type' : (dumpCommands and 'Commands') or 'Events' })
        self.dumpEventHandler(f)
        f.write('''
    }
}
''')
        f.close()
        
    def dumpClassEnum(self, f):
        f.write('''
        public enum ble_classes
        {''')
        for className in [x.name for x in self.classes]:
            f.write('''
            ble_cls_%(name)s,''' % { 'name' : className })
        f.write('''
        }
''')        
    def dumpEventHandler(self, f):
        f.write('''
        protected ble_event parseEvent(byte[] buffer)
        {
            int idx = SIZE_HEADER;
            ble_event res = null;
            int _length = ((buffer[0] & 0x7F) << 8) | buffer[1];
            switch(buffer[2])
            {''')
        for cls in self.classes:
            f.write('''
                case (byte)ble_classes.ble_cls_%(class)s:
                    switch(buffer[3])
                    {''' % { 'class' : cls.name })
            for evt in cls.events:
                f.write('''
                        case (byte)ble_event_ids.%(id)s:
                            {
                                %(struct)s s = new %(struct)s();%(body)s
                                check(idx, SIZE_HEADER + _length);
                                //%(call)s(s);
                                res = s;
                            }
                            break;''' % { 'id' : evt.id(), 'struct' : evt.struct(), 'body' : evt.dumpEventBody(), 'call' : evt.method_name() })
            f.write('''
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;''')
        f.write('''
                default:
                    throw new BLE112Exception(string.Format("Unknown class 0x{0}", buffer[2].ToString("X2")));
            }
            return res;
        }''')
    def dumpCommandsEnum(self, f):
        f.write('''
        public enum ble_command_ids
        {''')
        for cls in self.classes:
            for command in cls.commands:
                f.write('''
            ble_cmd_%(class)s_%(name)s_id = %(index)s,''' % { 'class' : cls.name, 'name' : command.name, 'index' : command.index })
        f.write('''
        }
''')        
    def dumpEventsEnum(self, f):
        f.write('''
        public enum ble_event_ids
        {''')
        for cls in self.classes:
            for event in cls.events:
                f.write('''
            ble_evt_%(class)s_%(name)s_id = %(index)s,''' % { 'class' : cls.name, 'name' : event.name, 'index' : event.index })
        f.write('''
        }
''')        
    def dumpEnumsEnum(self, f):
        for cls in self.classes:
            for enum in cls.enums:
                f.write('''
        public enum %(class)s_%(enum)s
        {''' % { 'class' : cls.name, 'enum' : enum.name })
                for value in enum.values:
                    f.write('''
            %(class)s_%(name)s = %(value)s,''' % { 'class' : cls.name, 'name' : value[0], 'value' : value[1] })
                f.write('''
        }
''')
    def dumpDefines(self, f):
        for cls in self.classes:
            for define in cls.defines:
                f.write('''
        // define %(class)s_%(define)s''' % { 'class' : cls.name, 'define' : define.name })
                for value in define.values:
                    f.write('''
        public const byte %(class)s_%(name)s = %(value)s;''' % { 'class' : cls.name.upper(), 'name' : value[0].upper(), 'value' : value[1] })
        f.write('''
''')

def bg_api(in_xml, out_cs):
    root = xml.dom.minidom.parse(in_xml).documentElement
    bgapi = BgApi()
    bgapi.parse(root)
    # FIXME dump
    bgapi.dump(out_cs)

if __name__ == '__main__':
    bg_api('../../../BlueGiga/ble-1.1.0-55/ble-1.1.0-55/ble/api/bleapi.xml', './BLE112.g.cs')
