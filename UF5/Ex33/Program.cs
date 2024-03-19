using System;
namespace ActividadesUF5
{
    public class Ex33
    {
        public static void Main()
        {
            List<string> cities = new List<string> { "ROMA", "LONDRES", "NAIROBI", "CALIFÒRNIA", "ZURICH", "NOVA DELHI", "AMSTERDAM", "ABU DHABI", "PARÍS" };
            var linqQuery = (string start, string end) => from city in cities
                                                          where city.StartsWith(start) && city.EndsWith(end)
                                                          select city;
            string first = Console.ReadLine().ToUpper();
            string last = Console.ReadLine().ToUpper();
            foreach (var city in linqQuery(first, last))
            {
                Console.WriteLine(city);
            }
        }
    }
}