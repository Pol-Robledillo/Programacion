using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    public class Pacient
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
        public Pacient(string Name, string Breed, int Age, bool Vaccinated)
        {
            this.Name = Name;
            this.Breed = Breed;
            this.Age = Age;
            this.Vaccinated = Vaccinated;
        }
    }
}
