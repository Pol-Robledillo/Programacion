using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class NumCard : ADeck
    {
        public int Number { get; set; }
        public NumCard(int number, string color, string type)
        {
            Number = number;
            Color = color;
            Type = type;
        }
    }
}