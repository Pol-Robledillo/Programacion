using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividades
{
    public class Ex15
    {
        public static void Main()
        {
            int year;
            const string MsgInputNumber = "Introdueix l'any: ";
            const string MsgLeapYear = "Aquest any és de traspas.";
            const string MsgNotLeapYear = "Aquest any no és de traspas.";

            Console.Write(MsgInputNumber);
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (ValidateYear(year))
            {
                Console.WriteLine(MsgLeapYear);
            } else
            {
                Console.WriteLine(MsgNotLeapYear);
            }
        }
        public static bool ValidateYear(int year)
        {
            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        return true;
                    } else 
                    {
                        return false;
                    }
                } else 
                {
                    return true;
                }
            } else
            {
                return false;
            }
        }
    }
}