using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr25
    {
        public static void Main()
        {
            int number, mult = 1;
            const string MsgInputFirst = "Introdueix el número: ";

            Console.Write(MsgInputFirst);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(DecToBin(number, mult));
        }
        public static int DecToBin(int number, int mult)
        {
            if (number == 1)
            {
                return (number % 2) * mult;
            } else
            {
                return ((number % 2) * mult) + DecToBin(number / 2, mult * 10);
            }
        }
    }
}