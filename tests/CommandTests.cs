using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            public MyBgApi(string comPort) : base(comPort) { }
        }
        
        MyBgApi dongle;

        [TestInitialize()]
        public async Task MyTestInitialize()
        {
            // FIXME: configure the serial port
            dongle = new MyBgApi("COM9");
            await dongle.Open();
        }
        
        [TestCleanup()]
        public void MyTestCleanup()
        {
            dongle.Close();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HelloAddressGetTest()
        {
            for (int i = 0; i < 10; i++)
            {
                // say 'hello'
                await dongle.ble_cmd_system_hello();

                // ask for underlying BT address
                var rsp = await dongle.ble_cmd_system_address_get();
                Assert.AreEqual(6, rsp.address.Length);
            }
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task TimerTest()
        {
            int numTimerCalls = 0;

            // setup callback
            dongle.BgApiEventHandler = evt => {
                Assert.AreEqual(evt.GetType(), typeof(BgApi.ble_msg_hardware_soft_timer_evt_t));

                var e = (BgApi.ble_msg_hardware_soft_timer_evt_t)evt;
                numTimerCalls++;
                return Task.FromResult(true);
            };

            // enable timer
            var rsp = await dongle.ble_cmd_hardware_set_soft_timer(35000 /* about every second */, 1, 0 /* periodic */);
            Assert.AreEqual(0, rsp.result);
            await Task.Delay(5000);
            // disable timer
            var rsp2 = await dongle.ble_cmd_hardware_set_soft_timer(0, 1, 0);
            Assert.AreEqual(0, rsp2.result);
            Assert.IsTrue(numTimerCalls >= 4, $"Expected at least 4 timer callbacks, got {numTimerCalls}");
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task DiscoverTest()
        {
            var rsp = await dongle.ble_cmd_gap_set_mode(2, 2);
            Assert.AreEqual(0, rsp.result);
            var rsp2 = await dongle.ble_cmd_gap_set_adv_parameters(2048, 2048, 7);
            Assert.AreEqual(0, rsp2.result);

            // setup callback
            dongle.BgApiEventHandler = evt => {
                Assert.AreEqual(evt.GetType(), typeof(BgApi.ble_msg_gap_scan_response_evt_t));

                var e = (BgApi.ble_msg_gap_scan_response_evt_t)evt;
                Console.WriteLine($"rssi: {e.rssi}, packet type: {e.packet_type}, sender: {e.sender}, address type: {e.address_type}, bond: {e.bond}");
                return Task.FromResult(true);
            };

            // start discovering
            var rsp3 = await dongle.ble_cmd_gap_discover(1);
            Assert.AreEqual(0, rsp3.result);

            // discovering
            await Task.Delay(5000);

            // stop
            var rsp4 = await dongle.ble_cmd_gap_end_procedure();
            Assert.AreEqual(0, rsp4.result);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task ConnectTest()
        {
            // FIXME: update manually
            var device2Connect = new[] { (byte)0x92, (byte)0xfc, (byte)0xab, (byte)0x06, (byte)0xde, (byte)0x50 };

            // setup callback
            dongle.BgApiEventHandler = evt => {
                Assert.AreEqual(evt.GetType(), typeof(BgApi.ble_msg_gap_scan_response_evt_t));

                var e = (BgApi.ble_msg_gap_scan_response_evt_t)evt;
                Console.WriteLine($"rssi: {e.rssi}, packet type: {e.packet_type}, sender: {e.sender}, address type: {e.address_type}, bond: {e.bond}");
                return Task.FromResult(true);
            };

            // start discovering
            var rsp3 = await dongle.ble_cmd_gap_discover(1);
            Assert.AreEqual(0, rsp3.result);

            // discovering
            await Task.Delay(5000);

            var tcs = new TaskCompletionSource();
            // setup callback, wait for connection to complete
            dongle.BgApiEventHandler = evt => {
                if (evt.GetType().Equals(typeof(BgApi.ble_msg_connection_version_ind_evt_t))) {
                    var e = (BgApi.ble_msg_connection_version_ind_evt_t)evt;
                    Console.WriteLine($"version: {e.vers_nr}, packet type: {e.comp_id}, sender: {e.sub_vers_nr}");
                    // signal connection result received
                    tcs.TrySetResult();
                }
                return Task.FromResult(true);
            };

            // connect to specific device
            var rsp4 = await dongle.ble_cmd_gap_connect_direct(
                new bd_addr() { Address = device2Connect },
                0, 60, 76, 100, 0);
            Assert.AreEqual(0, rsp4.result);
            int connection_handle = rsp4.connection_handle;

            // wait for connection to complete
            await tcs.Task;

            var rsp5 = await dongle.ble_cmd_attclient_read_by_group_type(connection_handle, 1, 65535, new byte[] { 0x00, 0x28 } );
            Assert.AreEqual(0, rsp5.result);

            // wait for all attributes read
            await Task.Delay(3000);

            var rsp6 = await dongle.ble_cmd_connection_disconnect(connection_handle);
            Assert.AreEqual(0, rsp6.result);
        }
    }
}
