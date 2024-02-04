using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class EffectCard : ADeck
    {
        public string Effect { get; set; }
        public EffectCard(string effect, string color, string type)
        {
            Effect = effect;
            Color = color;
            Type = type;
        }
    }
}