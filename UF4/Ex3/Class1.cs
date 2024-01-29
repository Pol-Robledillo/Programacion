using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Bicycle
    {
        private int price;
        private string brand, color;

        public int Price { get { return price; } set { price = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Bicycle(int price, string brand, string color)
        {
            this.price = price;
            this.brand = brand;
            this.color = color;
        }
    }
}