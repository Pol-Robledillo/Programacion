using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr24
    {
        public static void Main()
        {
            int firstNum, secondNum;
            const string MsgInputFirst = "Introdueix el primer número: ";
            const string MsgInputSecond = "Introdueix el segón número: ";

            Console.Write(MsgInputFirst);
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputSecond);
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(MultRusRec(firstNum, secondNum));
        }
        public static double MultRusIte(int firstNum, int secondNum)
        {
            int result = 0;

            do
            {
                if (ValidateOdd(firstNum))
                {
                    result += secondNum;
                }
                firstNum /= 2;
                secondNum *= 2;
            } while (firstNum != 1);
            result += secondNum;
            return result;
        }
        public static int MultRusRec(int firstNum, int secondNum)
        {
            if (firstNum == 1)
            {
                return secondNum;
            } else if (ValidateOdd(firstNum))
            {
                return secondNum + MultRusRec(firstNum / 2, secondNum * 2);
            } else
            {
                return MultRusRec(firstNum / 2, secondNum * 2);
            }
        }
        public static bool ValidateOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}
