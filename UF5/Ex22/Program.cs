using System;
namespace ActividadesUF5
{
    public class Ex19
    {
        public delegate void MyOperations(int num);
        public static void Main()
        {
            int num = 5;
            MyOperations MyOperation = Helper.EvenMult2;
            MyOperation(num);
        }
    }
}