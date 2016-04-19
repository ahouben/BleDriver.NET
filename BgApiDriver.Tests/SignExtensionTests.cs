/*
 * Copyright (c) 2012-2015 Alexander Houben (ahouben@greenliff.com)
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
