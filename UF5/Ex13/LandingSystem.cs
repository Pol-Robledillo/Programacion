using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class LandingSystem
    {
        public ExpertSystem? ExpertSystem { get; set; }
        public LandingSystem(ExpertSystem? expertSystem)
        {
            ExpertSystem = expertSystem;
        }
        public void Land(bool AIFunctional)
        {
            if (AIFunctional)
            {
                Console.WriteLine("Automatic landing");
            }
            else
            {
                Console.WriteLine("Manual landing");
            }
        }
    }
}
