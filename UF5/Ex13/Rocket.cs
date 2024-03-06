using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Rocket
    {
        public Motor? Motor1 { get; set; }
        public Motor? Motor2 { get; set; }
        public double Fuel { get; set; }
        public int Angle { get; set; }
        public Rocket(Motor motor1, Motor motor2, double fuel, int angle)
        {
            Motor1 = motor1;
            Motor2 = motor2;
            Fuel = fuel;
            Angle = angle;
        }
        public void ChangeDirection(int angle)
        {
            Angle += angle;
            Console.WriteLine("Direction changed by " + angle + " degrees.");
        }
    }
}
