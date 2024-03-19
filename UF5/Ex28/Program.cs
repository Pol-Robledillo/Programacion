using System;
namespace ActividadesUF5
{
    public class Ex28
    {
        public static void Main()
        {
            List<int> lista = [ 24, 34, -3, 4, 5, 6, 67, 8, 9, -10 ];
            var linqQuery = from num in lista
                            where num > 20
                            select num;
            foreach (int num in linqQuery)
            {
                Console.WriteLine(num + ": " + Math.Pow(num, 2));
            }
        }
    }
}