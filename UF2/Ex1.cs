using System;

namespace Metodes
{
    public class Pr1
    {
        public static void Main()
        {
            int firstNum, secondNum;
            bool isNatural = false;
            const string MsgNatural = "És natural";
            const string MsgNotNatural = "No és natural";
            const string MsgInputFirstNum = "Introdueix el primer número: ";
            const string MsgInputSecondNum = "Introdueix el segon número: ";

            Console.WriteLine(MsgInputFirstNum);
            do
            {
                firstNum = Convert.ToInt32(Console.ReadLine());
                isNatural = (Natural(firstNum));
                Console.WriteLine(isNatural ? MsgNatural : MsgNotNatural);
            } while (!isNatural);

            Console.WriteLine(MsgInputSecondNum);
            do
            {
                secondNum = Convert.ToInt32(Console.ReadLine());
                isNatural = (Natural(secondNum));
                Console.WriteLine(isNatural ? MsgNatural : MsgNotNatural);
            } while (!isNatural);

            Console.WriteLine(MesGran(firstNum, secondNum));
        }

        public static bool Natural(int num)
        {
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string MesGran(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return "El més gran és el primer";
            }
            else if (firstNum < secondNum)
            {
                return "El més gran és el segon";
            }
            else
            {
                return "Són iguals";
            }
        }
    }
}