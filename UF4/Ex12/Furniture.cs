using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    internal class Furniture
    {
        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set { get; set; }
        public string Color { get; set; }
        public Furniture(float weight, double price, bool set, string color)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Color = color;
        }
    }
}
