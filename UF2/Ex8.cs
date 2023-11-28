using System;

namespace Metodes
{
    class Pr8
    {
        public static void Main()
        {
            const int Numbers = 10, Min = 0, Max = 256;
            Random randomNumber = new Random();

            for (int i = 0; i < Numbers;  i++)
            {
                Console.WriteLine(randomNumber.Next(Min, Max));
            }
        }
    }
}
