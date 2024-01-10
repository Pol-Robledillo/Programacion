using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pometes
    {
        public static void Main()
        {
            int pometes;
            const string MsgInputFirst = "Introdueix el número de pomes: ";

            Console.Write(MsgInputFirst);
            pometes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            CountPometes(pometes);
        }
        public static void CountPometes(int pometes)
        {
            const string MsgLyrics = "{0} {1} té el pomer," +
                "\r\nde {0} una, de {0} una," +
                "\r\n{0} {1} té el pomer," +
                "\r\nde {0} una en caigué." +
                "\r\n" +
                "\r\nSi mireu el vent d'on vé" +
                "\r\nveureu el pomer com dansa," +
                "\r\nsi mireu el vent d'on vé" +
                "\r\nveureu com dansa el pomer.\n";
            if (pometes == 1)
            {
                Console.WriteLine(MsgLyrics, pometes, "pometa");
            } else
            {
                Console.WriteLine(MsgLyrics, pometes, "pometes");
                CountPometes(pometes - 1);
            }
        }
    }
}