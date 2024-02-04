using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Turtle : Animal
    {
        public string ShellColor { get; set; }
        public Turtle(string name, string species, int age, string shellColor)
        {
            Name = name;
            Species = species;
            Age = age;
            ShellColor = shellColor;
        }
        public void Swim()
        {
            Console.WriteLine("Turtle is swimming");
        }
    }
}