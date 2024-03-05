using System;
namespace Veterinario
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                int day, month, year;
                Console.WriteLine("Introduce un dia: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un mes: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un año: ");
                year = Convert.ToInt32(Console.ReadLine());
                DateTime date = new DateTime(year, month, day);

                if (date > DateTime.Now)
                {
                    TimeSpan difference = date - DateTime.Now;
                    Console.WriteLine("Falta " + difference.Days + " para la fecha indicada");
                }
                else
                {
                    TimeSpan difference = DateTime.Now - date;
                    Console.WriteLine("Han pasado " + difference.Days + " desde la fecha indicada");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}