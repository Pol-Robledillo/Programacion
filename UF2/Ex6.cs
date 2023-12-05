using System;

namespace Metodes
{
    public class Pr6
    {
        public static void Main()
        {
            int num;
            const string MsgInputNum = "Introdueix el número: ";
            const string MsgOutput = "El valor absolut del número {0} és {1}.";

            Console.Write(MsgInputNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgOutput, num, Math.Abs(num));
        }
    }
}
