using System;
namespace ActividadesUF5
{
    public class Ex4
    {
        public static void Main()
        {
            Employee employee = new Employee("Pol", "Robledillo", new DateTime(2005, 5, 12));
            Console.WriteLine(employee.GetAge());
        }
    }
}