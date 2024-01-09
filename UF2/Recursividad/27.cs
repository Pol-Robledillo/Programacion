using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr27
    {
        public static void Main()
        {
            int number;
            const string MsgInputFirst = "Introdueix el número: ";

            Console.Write(MsgInputFirst);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(IsPrime(number, number - 1));
        }
        public static bool IsPrime(int number, int div)
        {
            if (number == 2 || number == 1)
            {
                return true;
            } else if (div == 2)
            {
                return number % div != 0;
            } else
            {
                return number % div != 0 && IsPrime(number, div - 1);
            }
        }
    }
}