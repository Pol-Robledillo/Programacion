using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class SalesEmployee : Employee
    {
        public float Comission { get; set; }
        public SalesEmployee(string code, string name, string surname, DateTime birthDate, DateTime hireDate, float monthlySalary, int payments, float comission) : base(code, name, surname, birthDate, hireDate, monthlySalary, payments)
        {
            Comission = comission;
        }
        public SalesEmployee(string code, string name, string surname, DateTime birthDate, DateTime hireDate, float comission) : base(code, name, surname, birthDate, hireDate)
        {
            Comission = comission;
        }
        public override float GetAnnualSalary()
        {
            return base.GetAnnualSalary() + Comission;
        }
        public override string ToString()
        {
            return $"------------------------------------------------------------------------\r\n" +
                   $"                           SALES EMPLOYEE\r\n" +
                   $"------------------------------------------------------------------------\r\n" +
                   $">Code: {Code}\r\n" +
                   $">Name: {Name}\r\n" +
                   $">Surname: {Surname}\r\n" +
                   $">Full Name: {GetFullName()}\r\n" +
                   $">Full Name Reverse: {GetFullNameReverse()}\r\n" +
                   $">Age: {GetAge()}\r\n" +
                   $">Seniority: {GetAntiquity()}\r\n" +
                   $">Annual Salary: {MonthlySalary}\r\n" +
                   $">Comission: {Comission}\r\n" +
                   $"------------------------------------------------------------------------\r\n";
        }
    }
}
