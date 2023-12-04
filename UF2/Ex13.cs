using System;
namespace Actividades
{
    public class Ex13
    {
        public static void Main()
        {
            const int amountNumbers = 5;
            int[] numbers = new int[amountNumbers];
            const string MsgInputNumber = "Introdueix un número: ";

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(MsgInputNumber);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            OddPosition(numbers);
        }

        public static void OddPosition(int[] numbers)
        {
            for (int i = 0;i < numbers.Length;i += 2)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}