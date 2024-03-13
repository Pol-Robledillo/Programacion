namespace ActividadesUF5
{
    public class Ex18
    {
        public delegate int CompareBooks(Book b1, Book b2);
        public static void Main()
        {
            CompareBooks CustomCompare = Helper.Compare;
            List<Book> books =
            [
                new Book("The Hobbit", "J.R.R. Tolkien", 1937),
                new Book("The Fellowship of the Ring", "J.R.R. Tolkien", 1954),
                new Book("The Two Towers", "J.R.R. Tolkien", 1954),
                new Book("The Return of the King", "J.R.R. Tolkien", 1955),
            ];
            books.Sort((b1, b2) => CustomCompare(b1, b2));
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}