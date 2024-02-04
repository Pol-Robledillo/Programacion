using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class MotorBike : ATwoWheelsVehicle
    {
        public string Fuel { get; set; }
        public MotorBike(string color, int wheels, string fuel)
        {
            Color = color;
            Wheels = wheels;
            Fuel = fuel;
        }
    }
}