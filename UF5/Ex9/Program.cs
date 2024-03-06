using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex9
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in list.FindAll(x => x % 2 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}