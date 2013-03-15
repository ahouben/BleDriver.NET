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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

using BgApiDriver;

namespace BgApiDriver.Tests
{
    /// <summary>
    /// Basic command tests.
    /// </summary>
    [TestClass]
    public class CommandTests
    {
        class MyBgApi : BgApi
        {
            public int NumTimerCalls { get; set; }

            public MyBgApi(string comPort) : base(comPort) { }

            protected override void ble_evt_hardware_soft_timer(ble_msg_hardware_soft_timer_evt_t arg)
            {
                NumTimerCalls++;
            }
        }
        
        MyBgApi dongle;

        public CommandTests() { }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            // FIXME: configure the serial port
            dongle = new MyBgApi("COM3");
            dongle.Open();
        }
        
        [TestCleanup()]
        public void MyTestCleanup()
        {
            dongle.Close();
        }

        [TestMethod]
        public void HelloAddressGetTest()
        {
            for (int i = 0; i < 10; i++)
            {
                // say 'hello'
                dongle.ble_cmd_system_hello();

                // ask for underlying BT address
                var rsp = dongle.ble_cmd_system_address_get();
                Assert.AreEqual(6, rsp.address.Length);
            }
        }

        [TestMethod]
        public void TimerTest()
        {
            // enable timer
            var rsp = dongle.ble_cmd_hardware_set_soft_timer(35000 /* about every second */, 1, 0 /* periodic */);
            Assert.AreEqual(0, rsp.result);
            Thread.Sleep(5000);
            // disable timer
            var rsp2 = dongle.ble_cmd_hardware_set_soft_timer(0, 1, 0);
            Assert.AreEqual(0, rsp2.result);
            Assert.IsTrue(dongle.NumTimerCalls >= 4, string.Format("Expected at least 4 timer callbacks, got {0}", dongle.NumTimerCalls));
        }

    }
}
