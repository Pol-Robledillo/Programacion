using System;

namespace Metodes
{
    class Pr9
    {
        public static void Main()
        {
            int num;
            const string MsgInputFirstNum = "Introdueix la base: ";
            const string MsgInputSecondNum = "Introdueix l'exponent: ";

            Console.Write(MsgInputFirstNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Smaller(num));
            Console.WriteLine(Range(num));
        }

        public static string Range(int num)
        {
            int max, min;
            const string MsgInputMax = "Introdueix el màxim";
            const string MsgInputMin = "Introdueix el mínim";
            const string MsgInRange = "El número {0} es troba entre {1} i {2}.";
            const string MsgNotInRange = "El número {0} no es troba entre {1} i {2}.";

            Console.WriteLine(MsgInputMax);
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgInputMin);
            min = Convert.ToInt32(Console.ReadLine());

            return ((num > min) || (num < max)) ? MsgInRange : MsgNotInRange;
        }

        public static bool Smaller(int num)
        {
            int bigger;
            bigger = Convert.ToInt32(Console.ReadLine());

            if (num < bigger)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}