using System;
namespace ActividadesUF5
{
    public class Ex4
    {
        public static void Main()
        {
            try
            {
                DateTime actual = DateTime.Now;

                Console.WriteLine(actual.DayOfWeek.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}