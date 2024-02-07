using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class MyMath
    {
        private static Random random = new Random();
        public static int NextInt(int max)
        {
            return random.Next(max + 1);
        }
        public static string IntToHex(int value)
        {
            string hex = "";
            string hexFinal = "";
            if (value == 0)
            {
                return "00";
            } else
            {
                if (value < 16)
                {
                    hex += 0;
                }
                while (value > 0)
                {
                    hex += "0123456789ABCDEF"[value % 16];
                    value /= 16;
                }
            }
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                hexFinal += hex[i];
            }
            return hexFinal;
        }
    }
}
