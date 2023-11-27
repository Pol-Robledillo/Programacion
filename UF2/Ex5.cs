using System;

namespace Metodes
{
    public class Pr5
    {
        public static void Main()
        {
            int num;
            const string MsgInputNum = "Introdueix un número: ";

            Console.WriteLine(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(Comprovar(num) ? "És positiu i menor que 100" : "No és positiu i menor que 100");
        }

        public static bool Comprovar(int num)
        {
            if ((num > 0) && (num < 100))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
