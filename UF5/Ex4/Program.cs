using System;
namespace ActividadesUF5
{
    public class Ex4
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
                DateTime firstDate = new DateTime(year, month, day);

                Console.WriteLine("Introduce un dia: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un mes: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un año: ");
                year = Convert.ToInt32(Console.ReadLine());
                DateTime secondDate = new DateTime(year, month, day);

                Console.WriteLine(firstDate < secondDate ? "La segunda fecha es posterior a la primera" : "La segunda fecha no es posterior la primera");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}