using System;
namespace ActividadesUF5
{
    public class Ex19
    {
        public delegate double Raiz(int num);
        public static void Main()
        {
            int num = 9;
            Raiz CalcRaiz = Helper.CalcRaiz;
            double result = CalcRaiz(num);
            Console.WriteLine(result);
        }
    }
}