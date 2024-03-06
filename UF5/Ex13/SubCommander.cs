using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class SubCommander : Crew
    {
        public SubCommander(string? name, string? surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
