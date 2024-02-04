using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Boat : Vehicle
    {
        public bool Sail { get; set; }
        public Boat(string color, int speed, bool sail)
        {
            Color = color;
            Speed = speed;
            Sail = sail;
        }
    }
}