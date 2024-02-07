using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Circulo : AFigura
    {
        public double Radio { get; set; }
        public Circulo(int lados, double radio, Color backgroundColor, Color foreColor)
        {
            Lados = lados;
            Radio = radio;
            BackgroundColor = backgroundColor;
            ForeColor = foreColor;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}