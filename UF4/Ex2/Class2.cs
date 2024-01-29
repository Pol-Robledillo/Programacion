using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Lamp
    {
        private bool isOn;
        private string shape, lightbulbType;

        public bool IsOn { get { return isOn; } set { isOn = value; } }
        public string Shape { get { return shape; } set { shape = value; } }
        public string LightbulbType { get { return lightbulbType; } set { lightbulbType = value; } }
    }
}