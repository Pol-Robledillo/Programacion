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
            this.age = age;
            this.name = name;
            this.breed = breed;
            this.favFood = favFood;
        }
        public void Meow(string name)
        {
            Console.WriteLine($"{name} is meowing");
        }
        public void Play(string name)
        {
            Console.WriteLine($"{name} is playing");
        }
        public void Wash(string name)
        {
            Console.WriteLine($"{name} is washing himself");
        }
        public void Eat(string name, string favFood)
        {
            Console.WriteLine($"{name} is eating {favFood}");
        }
        public void Hunt(string name)
        {
            Console.WriteLine($"{name} is hunting");
        }
    }
}