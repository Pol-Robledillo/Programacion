using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Wolf : Animal
    {
        public string FurColor { get; set; }
        public Wolf(string name, string species, int age, string furColor)
        {
            Name = name;
            Species = species;
            Age = age;
            FurColor = furColor;
        }
        public void Howl()
        {
            Console.WriteLine("Wolf is howling");
        }
    }
}