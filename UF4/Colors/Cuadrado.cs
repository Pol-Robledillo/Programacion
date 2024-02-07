using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    internal class Cuadrado : AFigura
    {
        public double Lado { get; set; }
        public Cuadrado(int lados, double lado, Color backgroundColor, Color foreColor)
        {
            Lados = lados;
            Lado = lado;
            BackgroundColor = backgroundColor;
            ForeColor = foreColor;
        }
        public override double GetArea()
        {
            return Math.Pow(Lado, 2);
        }
    }
}
