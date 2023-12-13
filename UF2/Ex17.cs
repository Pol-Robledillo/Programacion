using System;

namespace Metodes
{
    class Pr17
    {
        public static void Main()
        {
            double temp;
            const string MsgInputCelsius = "Introdueix la temperatura en graus Celsius: ";
            const string MsgOutputFahrenheit = "La temperatura en graus Fahrenheit és {0}.";

            Console.Write(MsgInputCelsius);
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(MsgOutputFahrenheit, FahrenheitConversion(temp));
        }

        public static double FahrenheitConversion(double temp)
        {
            return (((temp * 9) / 5) + 32);
        }
    }
}