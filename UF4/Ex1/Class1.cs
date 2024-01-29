using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOOP
{
    public class Person
    {
        private string name, surname;
        private int age;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
