using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex11
    {
        public static void Main()
        {
            Dictionary<string, double> infoEmployee = new Dictionary<string, double>();
            infoEmployee.Add("Pol", 1800.33);
            infoEmployee.Add("Pau", 2000.33);
            infoEmployee.Add("Pep", 1500.33);
            infoEmployee.Add("Pablo", 2500.33);
            foreach (KeyValuePair<string, double> kvp in infoEmployee)
            {
                Console.WriteLine("Nombre: {0}, Salario: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}