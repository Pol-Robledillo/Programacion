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
        public static int CalcPotencia(int num, int exp)
        {
            if (exp == 0)
            {
                return 1;
            } else if (exp == 1)
            {
                return num;
            } else
            {
                return num * CalcPotencia(num, exp - 1);
            }
        }
    }
}
