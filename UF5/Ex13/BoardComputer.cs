using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class BoardComputer
    {
        public AI AI { get; set; }
        public BoardComputer(AI ai)
        {
            AI = ai;
        }
        public void CheckAI()
        {
            if (!AI.IsFunctional)
            {
                Console.WriteLine("AI is not functional");
            }
        }
    }
}
