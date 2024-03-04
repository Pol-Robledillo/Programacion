using System.Collections;
namespace ActividadesUF5
{
    public class Ex1
    {
        public static void Main()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("El Hobbit", 345));
            books.Add(new Book("El Quijote", 500));
            books.Add(new Book());
            books.Add(new Book("Los Juegos del Hambre", 267));
            books.Add(new Book("El Señor de los Anillos", 433));
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------------------------------------");
            books.Sort(new BookComparer());
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}