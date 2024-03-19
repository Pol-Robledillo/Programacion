using System;
namespace ActividadesUF5
{
    public class Ex26
    {
        public static void Main()
        {
            List<int> lista = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
            var linqQuery = from num in lista
                            where num % 2 == 0
                            select num;
            foreach (int num in linqQuery)
            {
                Console.WriteLine(num);
            }
        }
    }
}