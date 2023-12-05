using System;

namespace Metodes
{
    class Pr10
    {
        public static void Main()
        {
            int searchNum;
            const int Numbers = 10, Max = 200;
            const string MsgInputSearch = "Introdueix quin número vols buscar: ";
            const string MsgNumberFound = "El número {0} es troba a la llista.";
            const string MsgNumberNotFound = "El número {0} no es troba a la llista.";
            int[] randomNumbers = new int[Numbers];
            Random randomNumber = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = randomNumber.Next(Max);
            }

            Console.Write(MsgInputSearch);
            searchNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine((InArray(searchNum, randomNumbers) ? MsgNumberFound : MsgNumberNotFound), searchNum);
        }

        public static bool InArray(int searchNum, int[] list)
        {
            int search = 0;
            bool found = false;

            while ((search < list.Length) && (!found))
            {
                if (list[search] == searchNum)
                {
                    found = true;
                }
                search++;
            }
            return found;
        }
    }
}
