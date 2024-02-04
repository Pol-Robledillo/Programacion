using EjerciciosOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesOOP
{
    internal class UnMotoredVehicle : WheeledVehicle
    {
        public bool Gears { get; set; }
        public UnMotoredVehicle(string color, int speed, int wheels, bool gears)
        {
            Color = color;
            Speed = speed;
            Wheels = wheels;
            Gears = gears;
        }
    }
}
