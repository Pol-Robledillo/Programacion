using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Iguana : Animal
    {
        public string ScaleColor { get; set; }
        public Iguana(string name, string species, int age, string scaleColor)
        {
            Name = name;
            Species = species;
            Age = age;
            ScaleColor = scaleColor;
        }
        public void Climb()
        {
            Console.WriteLine("Iguana is climbing");
        }
    }
}
