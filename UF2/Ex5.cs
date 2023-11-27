using System;

namespace Metodes
{
    public class Pr5
    {
        public static void Main()
        {
            int num;
            const string MsgInputNum = "Introdueix un número: ";
            const string MsgCorrect = "És positiu i menor que 100";
            const string MsgIncorrect = "No és positiu i menor que 100";

            Console.WriteLine(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(Comprovar(num) ? MsgCorrect : MsgIncorrect);
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
