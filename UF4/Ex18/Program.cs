using System;
namespace EjerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            HourlyWorker hourlyWorker = new HourlyWorker("Juan", 40, 10);
            FullTimeWorker fullTimeWorker = new FullTimeWorker("Pedro", 40, 10);
            Console.WriteLine(hourlyWorker.computePay());
            Console.WriteLine(fullTimeWorker.computePay());
        }
    }
}