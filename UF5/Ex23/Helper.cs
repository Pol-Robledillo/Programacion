using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public static class Helper
    {
        public static void GetPositionFibonacci(int num)
        {
            int current = 1, next = 1, aux = 0, numPosition = 0;
            for (int i = 0; i < num; i++)
            {
                aux = current;
                current = next;
                next = aux + current;
                if (i == num - 2)
                {
                    numPosition = current;
                }
            }
            Console.WriteLine($"The number in the position {num} of the Fibonacci sequence is {numPosition}");
        }
    }
}
