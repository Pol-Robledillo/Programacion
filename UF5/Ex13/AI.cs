using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class AI
    {
        public bool IsFunctional { get; set; }
        public AI()
        {
            IsFunctional = true;
        }
        public void CheckSystems()
        {
            Console.WriteLine("Systems checked");
        }
    }
}
