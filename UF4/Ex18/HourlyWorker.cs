using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class HourlyWorker : AWorker
    {
        public int HorasTrabajadas { get; set; }
        public HourlyWorker(string name, int horasTrabajadas, int tarifa)
        {
            Name = name;
            HorasTrabajadas = horasTrabajadas;
            Tarifa = tarifa;
        }
        public override double computePay()
        {
            return Tarifa * HorasTrabajadas;
        }
    }
}
