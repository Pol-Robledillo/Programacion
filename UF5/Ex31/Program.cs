using System;
namespace ActividadesUF5
{
    public class Ex31
    {
        public static void Main()
        {
            List<int> days = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            var linqQuery = from day in days
                            select (DayOfWeek)day;
            foreach (var day in linqQuery)
            {
                Console.WriteLine(day);
            }
        }
    }
}