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

            Console.Write(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write(MsgInputBigger);
            bigger = Convert.ToInt32(Console.ReadLine());
            Smaller(num, bigger);
            Console.WriteLine();

            Console.Write(MsgInputMin);
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputMax);
            max = Convert.ToInt32(Console.ReadLine());
            Range(num, min, max);
        }

        public static void Smaller(int num, int bigger)
        {
            const string MsgIsSmaller = "{0} és més petit que {1}.";
            const string MsgIsNotSmaller = "{0} no és més petit que {1}.";

            Console.WriteLine((num < bigger ? MsgIsSmaller : MsgIsNotSmaller), num, bigger);
        }

        public static void Range(int num, int min, int max)
        {
            const string MsgInRange = "El número {0} es troba entre {1} i {2}.";
            const string MsgNotInRange = "El número {0} no es troba entre {1} i {2}.";

            Console.WriteLine((((num > min) && (num < max)) ? MsgInRange : MsgNotInRange), num, min, max);
        }
    }
}
