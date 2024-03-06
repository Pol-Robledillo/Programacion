using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex10
    {
        public static void Main()
        {
            string[] words = {"hola", "adios", "que tal", "hasta luego"};
            List<string> list = new List<string>(words);
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}