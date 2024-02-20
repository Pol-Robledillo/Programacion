using System;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
            card.Balance = 150;
            Console.WriteLine(card);
        }
    }
}