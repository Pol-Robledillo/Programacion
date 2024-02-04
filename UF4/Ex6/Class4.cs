using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class MotoredVehicle : WheeledVehicle
    {
        public string FuelType { get; set; }
        public int Doors { get; set; }
        public MotoredVehicle(string color, int speed, int wheels, string fuelType, int doors)
        {
            Color = color;
            Speed = speed;
            Wheels = wheels;
            FuelType = fuelType;
            Doors = doors;
        }
    }
}
