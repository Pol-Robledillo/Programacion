using System;
namespace ActividadesUF5
{
    public class Ex36
    {
        public static void Main()
        {
            List<string> strings = [ "cat", "dog", "rat" ];

            string result = strings.Aggregate((x, y) => x + y);
            Console.WriteLine(result);
        }
    }
}