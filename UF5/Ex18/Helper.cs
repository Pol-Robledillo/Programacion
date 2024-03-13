using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public static class Helper
    {
        public static int Compare(Book? x, Book? y)
        {
            if (x == null || y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return -x.Year.CompareTo(y.Year);
        }
    }
}
