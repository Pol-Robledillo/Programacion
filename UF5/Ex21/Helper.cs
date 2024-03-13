using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public static class Helper
    {
        public static double CalcAvg(double[] nums)
        {
            return nums.Sum() / nums.Length;
        }
    }
}
