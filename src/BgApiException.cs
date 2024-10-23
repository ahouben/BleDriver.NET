using System;

namespace BgApiDriver
{
    public class BgApiException : Exception
    {
        public BgApiException(string msg) : base(msg) { }
    }
}
