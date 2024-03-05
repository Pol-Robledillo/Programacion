using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Employee : IComparable
    {
        public static int NumberOfEmployees { get; private set; }
        private const int DEFAULT_PAYMENTS = 14;
        private const int DEFAULT_MONTHLY_SALARY = 1800;
        public string Code { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthlySalary { get; set; }
        public int Payments { get; set; }
        public Employee(string code, string name, string surname, DateTime birthDate, DateTime hireDate, float monthlySalary, int payments)
        {
            Code = code;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            HireDate = hireDate;
            MonthlySalary = monthlySalary;
            Payments = payments;
            NumberOfEmployees++;
        }

        public Employee(string code, string name, string surname, DateTime birthDate, DateTime hireDate) : this(code, name, surname, birthDate, hireDate, DEFAULT_MONTHLY_SALARY, DEFAULT_PAYMENTS) { }
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
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
        public string GetFullNameReverse()
        {
            return $"{Surname}, {Name}";
        }
        public int GetAntiquity()
        {
            DateTime actual = DateTime.Now;
            int years = actual.Year - HireDate.Year;
            if (actual.Month < HireDate.Month || (actual.Month == HireDate.Month && actual.Day < HireDate.Day))
            {
                years--;
            }
            return years;
        }
        public virtual float GetAnnualSalary()
        {
            return MonthlySalary * Payments;
        }
        public override string ToString()
        {
            return $"------------------------------------------------------------------------\r\n" +
                   $"                              EMPLOYEE\r\n" +
                   $"------------------------------------------------------------------------\r\n" +
                   $">Code: {Code}\r\n" +
                   $">Name: {Name}\r\n" +
                   $">Surname: {Surname}\r\n" +
                   $">Full Name: {GetFullName()}\r\n" +
                   $">Full Name Reverse: {GetFullNameReverse()}\r\n" +
                   $">Age: {GetAge()}\r\n" +
                   $">Seniority: {GetAntiquity()}\r\n" +
                   $">Annual Salary: {MonthlySalary}\r\n" +
                   $"------------------------------------------------------------------------\r\n";
        }
        public int CompareTo(object? obj)
        {
            Employee? e = obj as Employee;
            return -this.GetAntiquity().CompareTo(e.GetAntiquity());
        }
    }
}
