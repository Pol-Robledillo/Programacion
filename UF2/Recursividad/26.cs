using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr26
    {
        public static void Main()
        {
            int number;
            const string MsgInputFirst = "Introdueix el número: ";

            Console.Write(MsgInputFirst);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(SumDigits(number));
        }
        public static int SumDigits(int number)
        {
            if (number < 10)
            {
                return number;
            } else
            {
                return number % 10 + SumDigits(number / 10);
            }
        }
    }
}