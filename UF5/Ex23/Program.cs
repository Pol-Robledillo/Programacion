using System;
namespace ActividadesUF5
{
    public class Ex23
    {
        public delegate void MyOperations(int num);
        public static void Main()
        {
            int num = 8;
            MyOperations MyOperation = Helper.GetPositionFibonacci;
            MyOperation(num);
        }
    }
}