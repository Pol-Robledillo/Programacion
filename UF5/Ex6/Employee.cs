using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Employee
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Employee (string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
        public int GetAge()
        {
            DateTime actual = DateTime.Now;
            int age = actual.Year - BirthDate.Year;
            if (actual.Month < BirthDate.Month || (actual.Month == BirthDate.Month && actual.Day < BirthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}
