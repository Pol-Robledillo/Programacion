using System;
namespace ActividadesUF5
{
    public class Ex19
    {
        public delegate double MyAvg(double[] nums);
        public static void Main()
        {
            double[] nums = [ 4, 77, 3, 12, 56 ];
            MyAvg CalcRaiz = Helper.CalcAvg;
            double result = CalcRaiz(nums);
            Console.WriteLine(result);
        }
    }
}