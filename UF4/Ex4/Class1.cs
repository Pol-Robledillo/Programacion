using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Cat
    {
        private int age;
        private string name, breed, favFood;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Breed { get { return breed; } set { breed = value; } }
        public string FavFood { get { return favFood; } set { favFood = value; } }

        public Cat(int age, string name, string breed, string favFood)
        {
            this.Age = age;
            this.Name = name;
            this.Breed = breed;
            this.FavFood = favFood;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
        public void Wash()
        {
            Console.WriteLine($"{Name} is washing himself");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {FavFood}");
        }
        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting");
        }
    }
}
