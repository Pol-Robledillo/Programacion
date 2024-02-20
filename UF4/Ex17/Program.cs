using System;
namespace EjerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            Car myCar = new Car(0);
            myCar.Drive();
            myCar.Refuel(100);
            myCar.Drive();
        }
    }
}