using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Card card = new Card();
            card.IsSpecial = true;
            card.Content = "1";
            card.Color = "Red";
            Console.WriteLine("Card is special: " + card.IsSpecial);
            Console.WriteLine("Card content: " + card.Content);
            Console.WriteLine("Card color: " + card.Color);

            Lamp lamp = new Lamp();
            lamp.IsOn = true;
            lamp.Shape = "Round";
            lamp.LightbulbType = "LED";
            Console.WriteLine("Lamp is on: " + lamp.IsOn);
            Console.WriteLine("Lamp shape: " + lamp.Shape);
            Console.WriteLine("Lamp lightbulb type: " + lamp.LightbulbType);

            Flight flight = new Flight();
            flight.Price = 100;
            flight.Destination = "Madrid";
            flight.DepartureTime = "12:00";
            Console.WriteLine("Flight price: " + flight.Price);
            Console.WriteLine("Flight destination: " + flight.Destination);
            Console.WriteLine("Flight departure time: " + flight.DepartureTime);
        }
    }
}