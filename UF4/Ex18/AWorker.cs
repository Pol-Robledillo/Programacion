using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public abstract class AWorker
    {
        public string? Name { get; set; }
        public int Tarifa { get; set; }
        public abstract double computePay();
    }
}
