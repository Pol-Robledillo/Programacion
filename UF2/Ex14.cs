using System;
namespace Actividades
{
    public class Ex14
    {
        public static void Main()
        {
            int number, digits, sumEven, sumOdd;
            const string MsgInputNumber = "Introdueix un número: ";
            const string MsgOutputDigits = "Aquest número té {0} dígits.";
            const string MsgOutputSumEven = "La suma dels dígits parells és {0}.";
            const string MsgOutputSumOdd = "La suma dels dígits senars és {0}";

            Console.Write(MsgInputNumber);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            digits = CountDigits(number);
            Console.WriteLine(MsgOutputDigits, digits);

            sumEven = SumEven(number, digits);
            Console.WriteLine(MsgOutputSumEven, sumEven);

            sumOdd = SumOdd(number, digits);
            Console.WriteLine(MsgOutputSumOdd, sumOdd);
        }

        public static int CountDigits(int number)
        {
            int digits = 1;
            while (number > 9)
            {
                number /= 10;
                digits++;
            }
            return digits;
        }

        public static int SumEven(int number, int digits)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number  % 2 == 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }

        public static int SumOdd(int number, int digits)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
    }
}