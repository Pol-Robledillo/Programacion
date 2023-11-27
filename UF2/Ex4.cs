using System;

namespace Metodes
{
    public class Pr4
    {
        public static void Main()
        {
            int select;
            string text;
            const string MsgInputNum = "Introdueix un text: ";
            const string MsgSelect = "A que vols que es transformi? \n1. Majúscules \n2. Minúscules";

            Console.WriteLine(MsgInputNum);
            text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(MsgSelect);
            do
            {
                select = Convert.ToInt32(Console.ReadLine());
            } while ((select != 1) && (select != 2));

            Console.WriteLine(Transformar(text, select));
        }

        public static string Transformar(string text, int select)
        {
            if (select == 1)
            {
                text = text.ToUpper();
            } else
            {
                text = text.ToLower();
            }
            return text;
        }
    }
}
