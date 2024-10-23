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
    }
}
