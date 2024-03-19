using System;
namespace ActividadesUF5
{
    public class Ex29
    {
        public static void Main()
        {
            List<int> lista = [ -1, 2, -3, 2, 5, 6, -7, 8, -1, -10 ];
            var linqQuery = from num in lista
                            group num by num into counter
                            select new { Number = counter.Key, Frequency = counter.Count()};
            foreach (var num in linqQuery)
            {
                Console.WriteLine(num.Number + ": " + num.Frequency);
            }
        }
    }
}