using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Card
    {
        private bool isSpecial;
        private string content, color;

        public bool IsSpecial { get { return isSpecial; } set { isSpecial = value; } }
        public string Content { get { return content; } set { content = value; } }
        public string Color { get { return color; } set { color = value; } }
    }
}