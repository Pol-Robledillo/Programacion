using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public static class Helper
    {
        public static void EvenMult2(int num)
        {
            const string MsgOdd = "El número és senar";
            if (num % 2 == 0)
            {
                Console.WriteLine(num * 2);
            } else
            {
                Console.WriteLine(MsgOdd);
            }
        }
    }
}
