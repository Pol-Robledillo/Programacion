using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Flight
    {
        private int price;
        private string destination, departureTime;

        public int Price { get { return price; } set { price = value; } }
        public string Destination { get { return destination; } set { destination = value; } }
        public string DepartureTime { get { return departureTime; } set { departureTime = value; } }
    }
}