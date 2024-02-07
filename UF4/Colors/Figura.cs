using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public abstract class AFigura
    {
        public int Lados { get; set; }
        public Color? BackgroundColor { get; set; }
        public Color? ForeColor { get; set; }
        public abstract double GetArea();
    }
}
