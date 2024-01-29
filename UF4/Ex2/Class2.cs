using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    internal class Lamp
    {
        private bool isOn;


        public void SetIsOn(bool isOn)
        {
            this.isOn = isOn;
        }
        public bool GetIsOn()
        {
            return isOn;
        }
    }
}
