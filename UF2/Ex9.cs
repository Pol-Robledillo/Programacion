using System;

namespace Metodes
{
    class Pr9
    {
        public static void Main()
        {
            int num;
            const string MsgInputNum = "Introdueix un número: ";

            Console.Write(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Smaller(num);
            Console.WriteLine();
            Range(num);
        }

        public static void Smaller(int num)
        {
            int bigger;
            const string MsgInputBigger = "Quin número ha de ser més gran?  ";
            const string MsgIsSmaller = "{0} és més petit que {1}.";
            const string MsgIsNotSmaller = "{0} no és més petit que {1}.";

            Console.Write(MsgInputBigger);
            bigger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((num < bigger ? MsgIsSmaller : MsgIsNotSmaller), num, bigger);
        }

        public static void Range(int num)
        {
            int max, min;
            const string MsgInputMax = "Introdueix el màxim: ";
            const string MsgInputMin = "Introdueix el mínim: ";
            const string MsgInRange = "El número {0} es troba entre {1} i {2}.";
            const string MsgNotInRange = "El número {0} no es troba entre {1} i {2}.";

            Console.Write(MsgInputMin);
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputMax);
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((((num > min) && (num < max)) ? MsgInRange : MsgNotInRange), num, min, max);
        }
    }
}
