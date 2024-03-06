using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class NavigationSystem
    {
        public int Angle { get; set; }
        public NavigationSystem()
        {
            CalcAngle();
        }
        public int CalcAngle()
        {
            Random rnd = new Random();
            this.Angle = rnd.Next(-45, 46);
            return this.Angle;
        }
    }
}
