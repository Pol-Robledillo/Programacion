using System;
namespace ActividadesUF5
{
    public class Ex30
    {
        public static void Main()
        {
            string word = "Robledillo";
            var linqQuery = from c in word
                            group c by c into counter
                            select new { Character = counter.Key, Frequency = counter.Count()};
            foreach (var c in linqQuery)
            {
                Console.WriteLine(c.Character + ": " + c.Frequency);
            }
        }
    }
}