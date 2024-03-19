using System;
namespace ActividadesUF5
{
    public class Ex25
    {
        public static void Main()
        {
            Console.WriteLine("Ex1");
            Console.WriteLine(Identifier.Clean("my   Id"));
            Console.WriteLine();
            Console.WriteLine("Ex2");
            Console.WriteLine(Identifier.Clean("my\0Id"));
            Console.WriteLine();
            Console.WriteLine("Ex3");
            Console.WriteLine(Identifier.Clean("a-bc"));
            Console.WriteLine();
            Console.WriteLine("Ex4");
            Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
            Console.WriteLine();
            Console.WriteLine("Ex5");
            Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        }
    }
}