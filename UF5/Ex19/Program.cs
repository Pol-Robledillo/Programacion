using System;
namespace ActividadesUF5
{
    public class Ex19
    {
        public delegate int Potencia(int num, int exp);
        public static void Main()
        {
            Potencia CalcPotencia = Helper.CalcPotencia;
            int result = CalcPotencia(2, 3);
            Console.WriteLine(result);
        }
    }
}