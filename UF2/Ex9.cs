using System;

namespace Metodes
{
    class Pr9
    {
        public static void Main()
        {
            int num, bigger, max, min;
            string validation;
            const string MsgInputNum = "Introdueix un número: ";
            const string MsgInputBigger = "Quin número ha de ser més gran?  ";
            const string MsgInputMax = "Introdueix el màxim: ";
            const string MsgInputMin = "Introdueix el mínim: ";
            const string MsgIsSmaller = "El número a validar és més petit que el número indicat.";
            const string MsgIsNotSmaller = "El número a validar no és més petit que el número indicat.";
            const string MsgInRange = "El número es troba en el rang indicat.";
            const string MsgNotInRange = "El número no es troba en el rang indicat.";

            Console.Write(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write(MsgInputBigger);
            bigger = Convert.ToInt32(Console.ReadLine());
            validation = Validate(num, bigger) ? MsgIsSmaller : MsgIsNotSmaller;
            Console.WriteLine(validation);
            Console.WriteLine();

            Console.Write(MsgInputMin);
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputMax);
            max = Convert.ToInt32(Console.ReadLine());
            validation = (Validate(num, min, max) ? MsgInRange : MsgNotInRange);
            Console.WriteLine(validation);
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
