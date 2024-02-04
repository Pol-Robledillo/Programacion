using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Bike : ATwoWheelsVehicle
    {
        public bool Gears { get; set; }
        public Bike(string color, int wheels, bool gears)
        {
            Color = color;
            Wheels = wheels;
            Gears = gears;
        }
    }
}