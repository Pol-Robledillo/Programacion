using System;
namespace ActividadesUF5
{
    public class Ex32
    {
        public static void Main()
        {
            List<int> nums = new List<int> { 3, 2, 2, 3, 4, 2, 6 };
            var linqQuery = from num in nums
                            group num by num into g
                            select new { Number = g.Key, Count = g.Count(), Mult = g.Key * g.Count() };
            foreach (var num in linqQuery)
            {
                Console.WriteLine(num.Number + " * " + num.Count + " = " + num.Mult);
            }
        }
    }
}