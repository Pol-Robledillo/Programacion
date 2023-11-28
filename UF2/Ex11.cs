using System;

namespace Metodes
{
    class Pr8
    {
        public static void Main()
        {
            int num;
            bool invalidNum = false;
            const string MsgInput = "Introdueix un número: ";
            const string MsgInvalidNum = "El número no pot ser negatiu.";
            const string MsgOutput = "El factorial de {0} és {1}.";
            do
            {
                if (invalidNum)
                {
                    Console.WriteLine(MsgInvalidNum);
                    invalidNum = false;
                }
                Console.Write(MsgInput);
                num = Convert.ToInt32(Console.ReadLine());
                invalidNum = true;
            } while (num < 0);

            Console.WriteLine(MsgOutput, num, Factorial(num));
        }

        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}