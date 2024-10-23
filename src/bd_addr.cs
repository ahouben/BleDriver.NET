using System;

namespace BgApiDriver
{
    public class bd_addr
    {
        public byte[] Address { get; set; }
        public int Length { get { return 6; } }

        public bd_addr()
        {
            Address = new byte[Length];
        }

        public override string ToString()
        {
            string[] res = new string[Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = Address[i].ToString("X2");
            }
            return string.Join(".", res);
        } 
    }
}
