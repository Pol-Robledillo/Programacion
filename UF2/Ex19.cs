using System;

namespace Metodes
{
    class Pr19
    {
        public static void Main()
        {
            int firstNum, secondNum;
            const string MsgInputFirstNum = "Introdueix el primer número: ";
            const string MsgInputSecondNum = "Introdueix el segon número: ";
            const string MsgOutputMax = "El màxim és el {0}.";
            const string MsgOutputMin = "El mínim és el {0}.";

            Console.Write(MsgInputFirstNum);
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgInputSecondNum);
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgOutputMax, Math.Max(firstNum, secondNum));
            Console.WriteLine(MsgOutputMin, Math.Min(firstNum, secondNum));
        }
    }
}