using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    internal class Triangulo : AFigura
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public double Altura { get; set; }
        public Triangulo(int lados, double lado1, double lado2, double lado3, double altura, Color backgroundColor, Color foreColor)
        {
            Lados = lados;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
            Altura = altura;
            BackgroundColor = backgroundColor;
            ForeColor = foreColor;
        }
        public override double GetArea()
        {
            return (Lado1 * Altura) / 2;
        }
    }
}
