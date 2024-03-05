using System;
namespace Veterinario
{
    public class Program
    {
        public static void Main()
        {
            Owner owner = new Owner("12345678A", "Pedro", "Picapiedra", 123456789);
            Pacient pacient = new Pacient("Adolf", "German Shepherd", 5, true);
            Visit visit = new Visit(owner, pacient, "13/2/24", "Checkup");
            Console.WriteLine(visit.ToString());
        }
    }
}