/*
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
using System;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace BleDriver
{
    public partial class BLE112
    {
        /// <summary>
        /// The serial port we use to communicate with the BLE dongle.
        /// </summary>
        private SerialPort m_serialPort;

        /// <summary>
        /// The port name that the BLE dongle is connected to, ex. "COM3".
        /// </summary>
        private string m_port;

        /// <summary>
        /// The stream connected to <code>m_serialPort</code> we use to read/write to/from the BLE dongle.
        /// </summary>
        private Stream m_stream;

        private SerialDataReceivedEventHandler m_serialDataReceivedEventHandler;

        public bool IsOpen { get { return m_serialPort != null; } }

        /// <summary>
        /// Information about the ble device.
        /// </summary>
        public ble_msg_system_get_info_rsp_t Info { get; private set; }

        /// <summary>
        /// Wait handle for a response from the ble device.
        /// </summary>
        protected ManualResetEvent m_waitHandleResponse;

        /// <summary>
        /// Assumes that the maximum message size in bytes that ever goes over the wire in both directions is less than this value.
        /// </summary>
        public const int MAX_MESSAGE = 256;

        /// <summary>
        /// The maximum receive message size in bytes.
        /// </summary>
        public const int MAX_RECEIVE_MESSAGE = MAX_MESSAGE;

        /// <summary>
        /// The size of the header in bytes.
        /// </summary>
        public const int SIZE_HEADER = 4;

        /// <summary>
        /// Default wait time for the arrival of an event.
        /// </summary>
        public const int EVENT_TIMEOUT_DEFAULT = 1000;

        /// <summary>
        /// Receive buffer.
        /// </summary>
        byte[] m_rx;

        /// <summary>
        /// The number of valid receive bytes in the receive buffer <code>m_rx</code>.
        /// </summary>
        int m_rxOffset;

        private byte[] m_responseBytes;

        enum ble_msg_types
        {
            ble_msg_type_cmd = 0x00,
            ble_msg_type_rsp = 0x00,
            ble_msg_type_evt = 0x80,
        };

        enum ble_dev_types
        {
            ble_dev_type_ble = 0x00,
            ble_dev_type_wifi = 0x08,
            ble_dev_type_iwrap = 0x10,
        };

        enum ble_error_spaces
        {
            ble_err_bt = 512,
            ble_err_att = 1024,
            ble_err_bg = 256,
            ble_err_smp = 768,
        };

        public enum ble_error
        {
            ble_err_bt_error_success = ble_error_spaces.ble_err_bt + 0,   //Command completed succesfully
            ble_err_bt_bt_error_authentication_failure = ble_error_spaces.ble_err_bt + 5,   //Pairing or authentication failed due to incorrect results in the pairing or authentication procedure. This could be due to an incorrect PIN or Link Key
            ble_err_bt_pin_or_key_missing = ble_error_spaces.ble_err_bt + 6,   //Pairing failed because of missing PIN, or authentication failed because of missing Key
            ble_err_bt_bt_error_memory_capacity_exceeded = ble_error_spaces.ble_err_bt + 7,   //Controller is out of memory.
            ble_err_bt_connection_timeout = ble_error_spaces.ble_err_bt + 8,   //Link supervision timeout has expired.
            ble_err_bt_connection_limit_exceeded = ble_error_spaces.ble_err_bt + 9,   //Controller is at limit of connections it can support.
            ble_err_bt_bt_error_command_disallowed = ble_error_spaces.ble_err_bt + 12,  //Command requested cannot be executed because the Controller is in a state where it cannot process this command at this time.
            ble_err_bt_bt_error_invalid_command_parameters = ble_error_spaces.ble_err_bt + 18,  //Command contained invalid parameters.
            ble_err_bt_bt_error_remote_user_terminated = ble_error_spaces.ble_err_bt + 19,  //User on the remote device terminated the connection.
            ble_err_bt_bt_error_connection_terminated_by_local_host = ble_error_spaces.ble_err_bt + 22,  //Local device terminated the connection.
            ble_err_bt_bt_error_ll_response_timeout = ble_error_spaces.ble_err_bt + 34,  //Connection terminated due to link-layer procedure timeout.
            ble_err_bt_bt_error_ll_instant_passed = ble_error_spaces.ble_err_bt + 40,  //Received link-layer control packet where instant was in the past.
            ble_err_bt_bt_error_controller_busy = ble_error_spaces.ble_err_bt + 58,  //Operation was rejected because the controller is busy and unable to process the request.
            ble_err_bt_bt_error_directed_advertising_timeout = ble_error_spaces.ble_err_bt + 60,  //Directed advertising completed without a connection being created.
            ble_err_bt_bt_error_connection_terminated_due_to_mic_failure = ble_error_spaces.ble_err_bt + 61,  //Connection was terminated because the Message Integrity Check (MIC) failed on a received packet.
            ble_err_bt_bt_error_connection_failed_to_be_established = ble_error_spaces.ble_err_bt + 62,  //LL initiated a connection but the connection has failed to be established. Controller did not receive any packets from remote end.
            ble_err_att_invalid_handle = ble_error_spaces.ble_err_att + 1,  //The attribute handle given was not valid on this server
            ble_err_att_read_not_permitted = ble_error_spaces.ble_err_att + 2,  //The attribute cannot be read
            ble_err_att_write_not_permitted = ble_error_spaces.ble_err_att + 3,  //The attribute cannot be written
            ble_err_att_invalid_pdu = ble_error_spaces.ble_err_att + 4,  //The attribute PDU was invalid
            ble_err_att_insufficient_authentication = ble_error_spaces.ble_err_att + 5,  //The attribute requires authentication before it can be read or written.
            ble_err_att_request_not_supported = ble_error_spaces.ble_err_att + 6,  //Attribute Server does not support the request received from the client.
            ble_err_att_invalid_offset = ble_error_spaces.ble_err_att + 7,  //Offset specified was past the end of the attribute
            ble_err_att_insufficient_authorization = ble_error_spaces.ble_err_att + 8,  //The attribute requires authorization before it can be read or written.
            ble_err_att_prepare_queue_full = ble_error_spaces.ble_err_att + 9,  //Too many prepare writes have been queueud
            ble_err_att_att_not_found = ble_error_spaces.ble_err_att + 10, //No attribute found within the given attribute handle range.
            ble_err_att_att_not_long = ble_error_spaces.ble_err_att + 11, //The attribute cannot be read or written using the Read Blob Request
            ble_err_att_insufficient_enc_key_size = ble_error_spaces.ble_err_att + 12, //The Encryption Key Size used for encrypting this link is insufficient.
            ble_err_att_invalid_att_length = ble_error_spaces.ble_err_att + 13, //The attribute value length is invalid for the operation
            ble_err_att_unlikely_error = ble_error_spaces.ble_err_att + 14, //The attribute request that was requested has encountered an error that was unlikely, and therefore could not be completed as requested.
            ble_err_att_insufficient_encryption = ble_error_spaces.ble_err_att + 15, //The attribute requires encryption before it can be read or written.
            ble_err_att_unsupported_group_type = ble_error_spaces.ble_err_att + 16, //The attribute type is not a supported grouping attribute as defined by a higher layer specification.
            ble_err_att_insufficient_resources = ble_error_spaces.ble_err_att + 17, //Insufficient Resources to complete the request
            ble_err_att_application = ble_error_spaces.ble_err_att + 128,//Application error code defined by a higher layer specification.
            ble_err_success = 0,              //No error
            ble_err_invalid_param = ble_error_spaces.ble_err_bg + 128, //Command contained invalid parameter
            ble_err_wrong_state = ble_error_spaces.ble_err_bg + 129, //Device is in wrong state to receive command
            ble_err_out_of_memory = ble_error_spaces.ble_err_bg + 130, //Device has run out of memory
            ble_err_not_implemented = ble_error_spaces.ble_err_bg + 131, //Feature is not implemented
            ble_err_invalid_command = ble_error_spaces.ble_err_bg + 132, //Command was not recognized
            ble_err_timeout = ble_error_spaces.ble_err_bg + 133, //Command or Procedure failed due to timeout
            ble_err_not_connected = ble_error_spaces.ble_err_bg + 134, //Connection handle passed is to command is not a valid handle
            ble_err_flow = ble_error_spaces.ble_err_bg + 135, //Command would cause either underflow or overflow error
            ble_err_user_attribute = ble_error_spaces.ble_err_bg + 136, //User attribute was accessed through API which is not supported
            ble_err_smp_passkey_entry_failed = ble_error_spaces.ble_err_smp + 1,  //The user input of passkey failed, for example, the user cancelled the operation
            ble_err_smp_oob_not_available = ble_error_spaces.ble_err_smp + 2,  //Out of Band data is not available for authentication
            ble_err_smp_authentication_requirements = ble_error_spaces.ble_err_smp + 3,  //The pairing procedure cannot be performed as authentication requirements cannot be met due to IO capabilities of one or both devices
            ble_err_smp_confirm_value_failed = ble_error_spaces.ble_err_smp + 4,  //The confirm value does not match the calculated compare value
            ble_err_smp_pairing_not_supported = ble_error_spaces.ble_err_smp + 5,  //Pairing is not supported by the device
            ble_err_smp_encryption_key_size = ble_error_spaces.ble_err_smp + 6,  //The resultant encryption key size is insufficient for the security requirements of this device
            ble_err_smp_command_not_supported = ble_error_spaces.ble_err_smp + 7,  //The SMP command received is not supported on this device
            ble_err_smp_unspecified_reason = ble_error_spaces.ble_err_smp + 8,  //Pairing failed due to an unspecified reason
            ble_err_smp_repeated_attempts = ble_error_spaces.ble_err_smp + 9,  //Pairing or authentication procedure is disallowed because too little time has elapsed since last pairing request or security request
            ble_err_smp_invalid_parameters = ble_error_spaces.ble_err_smp + 10, //The Invalid Parameters error code indicates: the command length is invalid or a parameter is outside of the specified range.
            ble_err_last
        };

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="port">ex. "COM23"</param>
        public BLE112(string port)
        {
            m_port = port;

            m_rx = new byte[MAX_RECEIVE_MESSAGE];
            m_waitHandleResponse = new ManualResetEvent(false);
        }

        /// <summary>
        /// Opens the connection to a BLE device.
        /// 
        /// Note: must only be called within the synchronization context.
        /// </summary>
        public virtual void Open()
        {
            if (!IsOpen)
            {
                doOpen();
                ble_cmd_system_reset(0);
                Close();
                doOpen();

                Info = ble_cmd_system_get_info();
                log(string.Format("Build: {0}, protocol version: {1}, hardware: {2}", Info.build, Info.protocol_version,
                    Info.hw == 0x01 ? "BLE112" : Info.hw == 0x02 | Info.hw == 0x03 ? "BLED112" : string.Format("Unknown({0})", Info.hw)));
            }
        }

        private void doOpen()
        {
            m_serialPort = new SerialPort(m_port, 256000, Parity.None, 8, StopBits.One);
            // register for data received events
            m_serialDataReceivedEventHandler = new SerialDataReceivedEventHandler(m_serialPort_DataReceived);
            m_serialPort.DataReceived += m_serialDataReceivedEventHandler;
            m_serialPort.Open();
            m_stream = m_serialPort.BaseStream;
            m_rxOffset = 0;
        }

        /// <summary>
        /// Closes the stream and serial port to ta BLE device.
        /// </summary>
        public virtual void Close()
        {
            if (m_serialPort != null)
            {
                m_serialPort.DataReceived -= m_serialDataReceivedEventHandler;
                try { m_serialPort.Close(); } catch { }
                m_serialPort = null;
                m_stream = null;
            }
        }

        protected virtual void HandleEvent(ble_event evt)
        {
            // FIXME: implement
        }

        private void receive(SerialDataReceivedEventArgs e)
        {
            log(string.Format("Received: {0}", m_serialPort.BytesToRead));
            int read = m_stream.Read(m_rx, m_rxOffset, m_serialPort.BytesToRead);
            m_rxOffset += read;

            while (true)
            {
                log(string.Format("m_rxOffset: {0}", m_rxOffset));
                if (m_rxOffset < SIZE_HEADER)
                {
                    // wait for more data
                    log(string.Format("Waiting for header: {0}", m_rxOffset));
                    return;
                }

                // read payload
                int length = ((m_rx[0] & 0x7F) << 8) | m_rx[1];
                log(string.Format("length: {0}", length));
                if (m_rxOffset < SIZE_HEADER + length)
                {
                    // wait for more data
                    log(string.Format("Waiting for more data, expected {1}, got {0}", SIZE_HEADER + length, m_rxOffset));
                    return;
                }

                // full msg in m_rx, evt or rsp ?
                byte[] evtRspBuffer = new byte[SIZE_HEADER + length];
                Array.Copy(m_rx, evtRspBuffer, evtRspBuffer.Length);
                // remove first event
                int excessBytes = m_rxOffset - evtRspBuffer.Length;
                for (int i = 0; i < excessBytes; i++)
                {
                    m_rx[i] = m_rx[evtRspBuffer.Length + i];
                }
                m_rxOffset -= evtRspBuffer.Length;
                log(string.Format("m_rx_Offset to {0}", m_rxOffset));

                // FIXME: unify evt and rsp
                if ((evtRspBuffer[0] & 0x80) == 0x80)
                {
                    log(string.Format("evt: {0}", length));
                    ble_event evt = parseEvent(evtRspBuffer);
                    HandleEvent(evt);
                }
                else
                {
                    log(string.Format("rsp: {0}", length));
                    m_responseBytes = evtRspBuffer;
                    m_waitHandleResponse.Set();
                }
            }
        }

        /// <summary>
        /// Event handler for receiving data from the serial stream.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                receive(e);
            }
            catch (Exception ee)
            {
                // fatal: don't let it bubble up the stack
                Debugger.Break();
            }
        }

        /// <summary>
        /// Assert helper.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        private void check(int actual, int expected)
        {
            if (actual != expected)
            {
                throw new BLE112Exception(string.Format("Length mismatch. Actual {0}, expected {1}", actual, expected));
            }
        }

        /// <summary>
        /// Sends a command and receives a response from a Bluegiga BLE device.
        /// </summary>
        /// <param name="command">The command bytes.</param>
        /// <param name="offset">The offset within the command bytes.</param>
        /// <param name="length">The number of command bytes to send.</param>
        /// <param name="no_return">True, iff the command has a response (ex. reset does not return a response).</param>
        /// <returns>The response from the BLE device.</returns>
        private byte[] Send(byte[] command, int offset, int length, bool no_return)
        {
            try
            {
                Open();
                // wait for response
                m_waitHandleResponse.Reset();
                m_responseBytes = null;
                // write command
                m_stream.Write(command, offset, length);

                if (no_return)
                {
                    return null;
                }

                // what is the maximum expected wait time for a response
                if (!m_waitHandleResponse.WaitOne(2000))
                {
                    throw new BLE112Exception("Response timeout");
                }
                return m_responseBytes;
            }
            catch (Exception e)
            {
                log(e.Message);
                Close();
                throw e;
            }
        }

        /// <summary>
        /// All logging goes through this method for easy overriding.
        /// </summary>
        /// <param name="msg">The message to log.</param>
        protected virtual void log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
