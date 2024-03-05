using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    public class Visit
    {
        public Owner Owner { get; set; }
        public Pacient Pacient { get; set; }
        public string Date { get; set; }
        public string Reason { get; set; }
        public Visit(Owner Owner, Pacient Pacient, string Date, string Reason)
        {
            this.Owner = Owner;
            this.Pacient = Pacient;
            this.Date = Date;
            this.Reason = Reason;
        }
        public override string ToString()
        {
            return "DATE\t\t\t|OWNER\t\t\t|PACIENT\t\t|REASON\n" + Date + "\t\t\t|" + Owner.Name + " " + Owner.Surname + "\t|" + Pacient.Name + "\t\t\t|" + Reason;
        }
    }
}
