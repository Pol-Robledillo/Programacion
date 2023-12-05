using System;

namespace Metodes
{
    class Pr9
    {
        public static void Main()
        {
            int num, bigger, max, min;
            const string MsgInputNum = "Introdueix un número: ";
            const string MsgInputBigger = "Quin número ha de ser més gran?  ";
            const string MsgInputMax = "Introdueix el màxim: ";
            const string MsgInputMin = "Introdueix el mínim: ";
            const string MsgIsSmaller = "{0} és més petit que {1}.";
            const string MsgIsNotSmaller = "{0} no és més petit que {1}.";
            const string MsgInRange = "El número {0} es troba entre {1} i {2}.";
            const string MsgNotInRange = "El número {0} no es troba entre {1} i {2}.";

            Console.Write(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write(MsgInputBigger);
            bigger = Convert.ToInt32(Console.ReadLine());
            if (Validate(num, bigger))
            {
                Console.WriteLine(MsgIsSmaller);
            } else
            {
                Console.WriteLine(MsgIsNotSmaller);
            }
            Console.WriteLine();

            Console.Write(MsgInputMin);
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputMax);
            max = Convert.ToInt32(Console.ReadLine());
            if (Validate(num, min, max))
            {
                Console.WriteLine(MsgInRange);
            }
            else
            {
                Console.WriteLine(MsgNotInRange);
            }
        }

        public static bool Validate(int num, int bigger)
        {

            return num < bigger ? true : false;
        }

        public static bool Validate(int num, int min, int max)
        {
            return ((num > min) && (num < max)) ? true : false;
        }
    }
}
