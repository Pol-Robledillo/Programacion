using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null) return 0;
            if ( x== null) return -1;
            if (y == null) return 1;
            return -x.NumPages.CompareTo(y.NumPages);
        }
    }
}
