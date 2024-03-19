using System;
namespace ActividadesUF5
{
    public class Ex34
    {
        public static void Main()
        {
            const string InputMsg = "Introduce 5 numeros: ";
            const string OutputMsg = "Numeros mayores de 80: ";
            List<int> nums = new List<int>();
            Console.WriteLine(InputMsg);
            for (int i = 0; i < 5; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var linqQuery = from num in nums
                            where num > 80
                            select num;
            Console.WriteLine(OutputMsg);
            foreach (var num in linqQuery)
            {
                Console.WriteLine(num);
            }
        }
    }
}