using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Card card = new Card();
            card.SetIsSpecial(true);
            card.SetContent("1");
            card.SetColor("Red");
            Console.WriteLine("Card is special: " + card.GetIsSpecial());
            Console.WriteLine("Card content: " + card.GetContent());
            Console.WriteLine("Card color: " + card.GetColor());

            Lamp lamp = new Lamp();
            lamp.SetIsOn(true);

        }
    }
}