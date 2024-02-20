using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Car : IVehicle
    {
        public int Fuel { get; set; }
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
        }
        public bool Refuel(int Amount)
        {
            Fuel += Amount;
            return true;
        }
    }
}
