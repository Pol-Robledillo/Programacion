using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Cat cat1 = new Cat(4, "Francisco", "Persian", "Sardines");
            Cat cat2 = new Cat(6, "Adolf", "German Rex", "Milk");
            Cat cat3 = new Cat(5, "Benito", "Sphynx", "Tuna");
            Cat cat4 = new Cat(2, "Kim", "Li Hua", "Salmon");

            cat1.Meow();
            cat2.Play();
            cat3.Wash();
            cat4.Eat();
            cat1.Hunt();
        }
    }
}
