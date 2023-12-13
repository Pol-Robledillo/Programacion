using System;

namespace Metodes
{
    class Pr18
    {
        public static void Main()
        {
            bool error = false;
            double time;
            const string MsgInputMinutes = "Introdueix el temps en minuts: ";
            const string MsgError = "El temps no pot ser negatiu.";
            const string MsgOutputSeconds = "{0} minuts són {1} segons.";

            do
            {
                Console.Write(MsgInputMinutes);
                time = Convert.ToDouble(Console.ReadLine());
                if (!ValidateTime(time)) {
                    error = true;
                    Console.WriteLine(MsgError);
                }
                Console.WriteLine();
            } while (error);

            Console.WriteLine(MsgOutputSeconds, time, MinutesToSeconds(time));
        }

        public static bool ValidateTime(double time)
        {
            return time > 0 ? true : false;
        }

        public static double MinutesToSeconds(double time)
        {
            return (time * 60);
        }
    }
}