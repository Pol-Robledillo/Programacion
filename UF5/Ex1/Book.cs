using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Book : IComparable<Book>
    {
        public static int CurrentId = 1;
        const string DefaultTitle = "Unknown";
        const int DefaultNumPages = 0;
        public int Id { get; set; }
        public string? Title { get; set; }
        public int NumPages { get; set; }
        public Book(string title, int numPages)
        {
            Id = CurrentId;
            Title = title;
            NumPages = numPages;
            CurrentId++;
        }
        public Book()
        {
            Id = CurrentId;
            Title = DefaultTitle;
            NumPages = DefaultNumPages;
            CurrentId++;
        }
        public override string ToString()
        {
            return "Id: " + Id + " | Title: " + Title + " | NumPages: " + NumPages;
        }
        public int CompareTo(Book? other)
        {
            return this.NumPages.CompareTo(other?.NumPages);
        }
    }
}
