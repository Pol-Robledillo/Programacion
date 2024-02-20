using System;
namespace EjerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            VendingMachine vendingMachine = new VendingMachine(100);
            Console.WriteLine(vendingMachine.BuyTicket(2, 2.5));
        }
    }
}