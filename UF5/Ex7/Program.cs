using System;
namespace ActividadesUF5
{
    public class Ex4
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("E1", "Pol", "Robledillo", new DateTime(2005, 5, 12), new DateTime(2020, 5, 12), 2000, 14));
            employees.Add(new Employee("E2", "Pau", "Robledillo", new DateTime(2004, 4, 12), new DateTime(2018, 5, 12), 2000, 14));
            employees.Add(new Employee("E3", "Pep", "Robledillo", new DateTime(2003, 3, 12), new DateTime(2016, 5, 12), 2000, 14));
            employees.Add(new Employee("E4", "Pere", "Robledillo", new DateTime(2002, 2, 12), new DateTime(2014, 5, 12), 2000, 14));
            employees.Add(new Employee("E5", "Pablo", "Robledillo", new DateTime(2001, 1, 12), new DateTime(2012, 5, 12), 2000, 14));
            employees.Sort();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
            List<SalesEmployee> salesEmployees = new List<SalesEmployee>();
            salesEmployees.Add(new SalesEmployee("SE1", "Peter", "Parker", new DateTime(1962, 1, 1), new DateTime(2016, 1, 1), 2000, 15, 134.1f));
            salesEmployees.Add(new SalesEmployee("SE2", "Clark", "Kent", new DateTime(1938, 1, 1), new DateTime(2015, 1, 1), 2000, 15, 426.1f));
            salesEmployees.Add(new SalesEmployee("SE3", "Bruce", "Wayne", new DateTime(1939, 1, 1), new DateTime(2008, 1, 1), 2000, 15, 500.1f));
            salesEmployees.Add(new SalesEmployee("SE4", "Tony", "Stark", new DateTime(1963, 1, 1), new DateTime(2008, 1, 1), 2000, 15, 1345.6f));
            salesEmployees.Add(new SalesEmployee("SE5", "Steve", "Rogers", new DateTime(1941, 1, 1), new DateTime(2009, 1, 1), 2000, 15, 1000f));
            salesEmployees.Sort();
            foreach (SalesEmployee emp in salesEmployees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
