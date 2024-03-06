using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Motor
    {
        public int ActivationCode { get; set; }
        private Motor(int activationCode)
        {
            ActivationCode = activationCode;
        }
        public static Motor Build(int activationCode)
        {
            return new Motor(activationCode);
        }
        public void Start(int activationCode, double fuel)
        {
            Console.WriteLine(activationCode == ActivationCode ? fuel > 0 ? "Motor started" : "No fuel" : "Wrong activation code");
        }
        public void Stop()
        {
            Console.WriteLine("Motor stopped");
        }
    }
}
