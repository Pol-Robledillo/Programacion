using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string MsgFileInput = "Introdueix la ruta del fitxer (ha de tenir l'extenxió .txt): ";
        const string MsgWrongExtension = "L'arxiu ha de tenir l'extensió .txt, torna a provar: ";
        const string MsgAddContent = "Introdueix el text que vols afegir al fitxer: ";
        const string MsgSuccessful = "Operació completada.";
        const string MsgOptions = "Que vols fer? \n1. Llegir \n2. Escriure";
        const string MsgWrongChoice = "Opció no vàlida";
        const string MsgError = "S'ha produït un error: {0}";
        int choice = 0;
        string fileName;

        try
        {
            Console.WriteLine(MsgFileInput);
            do
            {
                fileName = Console.ReadLine();
                if (!fileName.EndsWith(".txt"))
                {
                    Console.WriteLine(MsgWrongExtension);
                }
            } while (!fileName.EndsWith(".txt"));

            Console.WriteLine(MsgOptions);
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReadFile(fileName);
                    break;
                case 2:
                    Console.WriteLine(MsgAddContent);
                    string content = Console.ReadLine();
                    WriteFile(fileName, content);
                    Console.WriteLine(MsgSuccessful);
                    break;
                default:
                    Console.WriteLine(MsgWrongChoice);
                    choice = Convert.ToInt32(Console.ReadLine());
                    break;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(MsgError, ex.Message);
        }
    }

    static void ReadFile(string fileName)
    {
        const string MsgShowContent = "Contingut del fitxer {0}:\n";
        const string MsgNotExists = "El fitxer {0} no existeix.";
        const string MsgShowLines = "El fitxer {0} té {1} línies.";
        int numLines;

        if (File.Exists(fileName))
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string[] content = File.ReadAllLines(fileName);
                numLines = content.Length;
                Console.WriteLine(MsgShowContent, fileName);
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(content[i]);
                }
                Console.WriteLine(MsgShowLines, fileName, numLines);
            }
        }
        else
        {
            Console.WriteLine(MsgNotExists, fileName);
        }
    }

    static void WriteFile(string fileName, string content)
    {
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            sw.WriteLine(content);
        }
    }
}
