using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BleDriver.Tests
{
    /// <summary>
    /// Test conversion of bytes to the appropriate signed or unsigned value.
    /// </summary>
    [TestClass]
    public class SignExtensionTests
    {
        [TestMethod]
        public void SignExtensionTest()
        {
            var buffer = new byte[] { 0xff, 0xff, 0xff, 0xff };

            // int8
            int idx = 0;
            int i_s = (sbyte)buffer[idx++];
            Assert.AreEqual(-1, i_s);

            // uint8
            idx = 0;
            int i_u = buffer[idx++];
            Assert.AreEqual(255, i_u);

            // int16
            idx = 0;
            int i2_s = buffer[idx + 0] | (((sbyte)buffer[idx + 1]) << 8); idx += 2;
            Assert.AreEqual(-1, i2_s);

            // uint16
            idx = 0;
            int i2_u = buffer[idx + 0] | (buffer[idx + 1] << 8); idx += 2;
            Assert.AreEqual(65535, i2_u);

            // int32
            idx = 0;
            int i4_s = buffer[idx + 0] | (buffer[idx + 1] << 8) | (buffer[idx + 2] << 16) | ((sbyte)buffer[idx + 3] << 24); idx += 4;
            Assert.AreEqual(-1, i4_s);

            // uint32
            idx = 0;
            long i4_uu = buffer[idx + 0] + buffer[idx + 1] * 0x100 + buffer[idx + 2] * 0x10000 + buffer[idx + 3] * (long)0x1000000; idx += 4;
            Assert.AreEqual(4294967295, i4_uu);
        }
    }
}
