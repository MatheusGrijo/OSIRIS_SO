using System;
using System.Text;

namespace OSIRIS
{
    public class Utils
    {
        public static string ArrayToString(byte[] arr)
        {
            StringBuilder s = new StringBuilder(arr.Length * 2);
            for (int i = 0; i < arr.Length; ++i)
            {
                s.AppendFormat("{0:x2}", arr[i]);
            }

            return s.ToString();
        }

        public static byte[] ConcatAddress(byte[] RipeHash, byte[] Checksum)
        {
            byte[] ret = new byte[RipeHash.Length + 4];
            Array.Copy(RipeHash, ret, RipeHash.Length);
            Array.Copy(Checksum, 0, ret, RipeHash.Length, 4);
            return ret;
        }


        public static byte[] AppendBitcoinNetwork(byte[] RipeHash, byte Network)
        {
            byte[] extended = new byte[RipeHash.Length + 1];
            extended[0] = (byte)Network;
            Array.Copy(RipeHash, 0, extended, 1, RipeHash.Length);
            return extended;
        }

        public static byte[] ToByteArray(String hexString)
        {
            byte[] retval = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
                retval[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            return retval;
        }

        public static string BinaryToHex(String value)
        {
            String hex = String.Empty;
            if (value.Substring(0, 4).Equals("0000"))
                hex += "0";
            if (value.Substring(0, 4).Equals("0001"))
                hex += "1";
            if (value.Substring(0, 4).Equals("0010"))
                hex += "2";
            if (value.Substring(0, 4).Equals("0011"))
                hex += "3";
            if (value.Substring(0, 4).Equals("0100"))
                hex += "4";
            if (value.Substring(0, 4).Equals("0101"))
                hex += "5";
            if (value.Substring(0, 4).Equals("0110"))
                hex += "6";
            if (value.Substring(0, 4).Equals("0111"))
                hex += "7";
            if (value.Substring(0, 4).Equals("1000"))
                hex += "8";
            if (value.Substring(0, 4).Equals("1001"))
                hex += "9";
            if (value.Substring(0, 4).Equals("1010"))
                hex += "A";
            if (value.Substring(0, 4).Equals("1011"))
                hex += "B";
            if (value.Substring(0, 4).Equals("1100"))
                hex += "C";
            if (value.Substring(0, 4).Equals("1101"))
                hex += "D";
            if (value.Substring(0, 4).Equals("1110"))
                hex += "E";
            if (value.Substring(0, 4).Equals("1111"))
                hex += "F";

            return hex;
        }
    }
}
