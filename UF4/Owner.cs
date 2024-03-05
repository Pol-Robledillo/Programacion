using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    public class Owner
    {
        public string DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public Owner(string DNI, string Name, string Surname, int Phone)
        {
            this.DNI = DNI;
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
        }
    }
}
