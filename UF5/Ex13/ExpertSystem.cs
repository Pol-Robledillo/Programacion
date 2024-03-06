using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class ExpertSystem
    {
        public int BestAngle { get; set; }
        public ExpertSystem()
        {
            CalcBestAngle();
        }
        public void CalcBestAngle()
        {
            Random rnd = new Random();
            this.BestAngle = rnd.Next(1, 180);
        }
    }
}
