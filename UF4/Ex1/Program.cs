using System;
using EjerciciosOOP;
namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.SetName("Pol");
            person.SetSurname("Robledillo");
            person.SetAge(18);
            Console.WriteLine("Name: {0}", person.GetName());
            Console.WriteLine("Surname: {0}", person.GetSurname());
            Console.WriteLine("Age: {0}", person.GetAge());
        }
    }
}