using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex8
    {
        public static void Main()
        {
            int suma = 0;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach (int i in list)
            {
                suma += i;
            }
            Console.WriteLine("La suma de los elementos de la lista es: " + suma);
        }
    }
}