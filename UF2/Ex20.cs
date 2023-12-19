using System;

namespace Metodes
{
    class Pr20
    {
        public static void Main()
        {
            double num, decimals;
            const string MsgInputNumber = "Introdueix un número decimal: ";
            const string MsgOutputNumber = "La part entera del número és {0} i la part decimal és {1}.";

            Console.Write(MsgInputNumber);
            num = Convert.ToDouble(Console.ReadLine());

            decimals = GetDecimals(num);

            Console.WriteLine(MsgOutputNumber, (Math.Round(num, MidpointRounding.ToZero)), decimals);
        }
        public static double GetDecimals(double num)
        {
            return num - (Math.Round(num, MidpointRounding.ToZero));
        }
    }
}