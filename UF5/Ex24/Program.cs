using System;
namespace ActividadesUF5
{
    public class Ex24
    {
        public delegate bool MyOperations(int num);
        public static void Main()
        {
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                MyOperations MyOperation = Helper.IsNatural;
                Console.WriteLine(MyOperation(num) ? "És natural" : "No és natural");
            } catch (Exception OverflowException)
            {
                Console.WriteLine("No és natural");
            }
        }
    }
}