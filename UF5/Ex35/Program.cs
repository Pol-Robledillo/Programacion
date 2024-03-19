using System;
namespace ActividadesUF5
{
    public class Ex35
    {
        public static void Main()
        {
            string text = "HOLA que Tal";
            string[] words = text.Split();
            var linqQuery = from word in words
                            where word == word.ToUpper()
                            select word;
            foreach (var word in linqQuery)
            {
                Console.WriteLine(word);
            }
        }
    }
}