using System;

namespace Metodes
{
    class Pr16
    {
        public static void Main()
        {
            bool error = false;
            int numAmount, bigger, num, attempts = 5;
            const int Min = 15, Max = 100;
            const string MsgInputNumAmount = "Introdueix quants números vols introduïr: ";
            const string MsgInputNum = "Introdueix un número entre 15 i 100: ";
            const string MsgError = "Aquest número es troba a fora del rang. Intents restants: {0}.";
            const string MsgOutput = "El producte de tots aquests números és {0}.";

            Console.Write(MsgInputNumAmount);
            numAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] numbers = new int[numAmount];

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write(MsgInputNum);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (!ValidateRange(numbers[i], Min, Max)) {
                        error = true;
                        attempts--;
                        Console.WriteLine(MsgError, attempts);
                    }
                    Console.WriteLine();
                } while ((error) && (attempts > 0));
                if (attempts <= 0)
                {
                    i = numbers.Length;
                }
            }
            if (attempts > 0)
            {
                Console.WriteLine(MsgOutput, Product(numbers));
            }
        }

        public static bool ValidateRange(int num, int min, int max)
        {
            return num > min && num < max ? true : false;
        }

        public static int Product(int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}