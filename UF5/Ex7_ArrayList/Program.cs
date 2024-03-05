using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex4
    {
        public static void Main()
        {
            ArrayList allEmployees = new ArrayList();
            allEmployees.Add(new Employee("E1", "Pol", "Robledillo", new DateTime(2005, 5, 12), new DateTime(2020, 5, 12), 2000, 14));
            allEmployees.Add(new Employee("E2", "Pau", "Robledillo", new DateTime(2004, 4, 12), new DateTime(2018, 5, 12), 2000, 14));
            allEmployees.Add(new Employee("E3", "Pep", "Robledillo", new DateTime(2003, 3, 12), new DateTime(2016, 5, 12), 2000, 14));
            allEmployees.Add(new Employee("E4", "Pere", "Robledillo", new DateTime(2002, 2, 12), new DateTime(2014, 5, 12), 2000, 14));
            allEmployees.Add(new Employee("E5", "Pablo", "Robledillo", new DateTime(2001, 1, 12), new DateTime(2012, 5, 12), 2000, 14));
            allEmployees.Add(new SalesEmployee("SE1", "Peter", "Parker", new DateTime(1962, 1, 1), new DateTime(2016, 1, 1), 2000, 15, 134.1f));
            allEmployees.Add(new SalesEmployee("SE2", "Clark", "Kent", new DateTime(1938, 1, 1), new DateTime(2015, 1, 1), 2000, 15, 426.1f));
            allEmployees.Add(new SalesEmployee("SE3", "Bruce", "Wayne", new DateTime(1939, 1, 1), new DateTime(2008, 1, 1), 2000, 15, 500.1f));
            allEmployees.Add(new SalesEmployee("SE4", "Tony", "Stark", new DateTime(1963, 1, 1), new DateTime(2008, 1, 1), 2000, 15, 1345.6f));
            allEmployees.Add(new SalesEmployee("SE5", "Steve", "Rogers", new DateTime(1941, 1, 1), new DateTime(2009, 1, 1), 2000, 15, 1000f));
            allEmployees.Sort();
            for (int i = 0; i < allEmployees.Count; i++)
            {
                Console.WriteLine(allEmployees[i].ToString());
            }
        }
    }
}