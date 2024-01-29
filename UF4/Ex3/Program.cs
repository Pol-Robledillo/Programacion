using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Bicycle mountainBike = new Bicycle(100, "Noseque", "Red");
            Bicycle roadBike = new Bicycle(200, "Noseque2", "Blue");
            Console.WriteLine("Mountain bike price: " + mountainBike.Price);
            Console.WriteLine("Road bike price: " + roadBike.Price);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Mountain bike brand: " + mountainBike.Brand);
            Console.WriteLine("Road bike brand: " + roadBike.Brand);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Mountain bike color: " + mountainBike.Color);
            Console.WriteLine("Road bike color: " + roadBike.Color);
        }
    }
}