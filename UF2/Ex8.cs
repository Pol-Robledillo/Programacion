using System;

namespace Metodes
{
    class Pr8
    {
        public static void Main()
        {
            const int Numbers = 10, Max = 257;
            Random randomNumber = new Random();

            for (int i = 0; i < Numbers;  i++)
            {
                Console.WriteLine(randomNumber.Next(Min, Max));
            }
        }
    }
}
