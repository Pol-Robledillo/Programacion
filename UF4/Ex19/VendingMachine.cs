using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class VendingMachine
    {
        private double[] coinValues = new double[] { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
        private const double ticketPrice = 1.2;
        public double Box { get; set; }
        public VendingMachine(double box)
        {
            Box = box;
        }
        public string BuyTicket(int amount, double money)
        {
            string output = "";
            if ((amount * ticketPrice) > money)
            {
                return "Not enough money for that amount of tickets";
            } else
            {
                if (money - (amount * ticketPrice) > Box)
                {
                    return "Not enough change in the machine";
                } else
                {
                    int[] change = GetChange(money - (amount * ticketPrice));
                    Box += (amount * ticketPrice);
                    for (int i = 0; i < change.Length; i++)
                    {
                        output += coinValues[i] + ": " + change[i] + "\n";
                    }
                    return output;
                }
            }
        }
        public int[] GetChange(double change)
        {
            int[] coins = new int[14];
            for (int i = 0; i < coinValues.Length; i++)
            {
                while (change >= coinValues[i])
                {
                    change -= coinValues[i];
                    coins[i]++;
                }
            }
            return coins;
        }
    }
}
