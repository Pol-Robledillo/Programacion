using System;

namespace Metodes
{
    class Pr7
    {
        public static void Main()
        {
            int firstNum, secondNum;
            const string MsgInputFirstNum = "Introdueix la base: ";
            const string MsgInputSecondNum = "Introdueix l'exponent: ";
            const string MsgOutput = "El resultat d'elevar {0} a {1} és {2}";

            Console.Write(MsgInputFirstNum);
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputSecondNum);
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgOutput, firstNum, secondNum, Potencia(firstNum, secondNum));
        }

        public static double Potencia(int firstNum, int secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }
    }
}