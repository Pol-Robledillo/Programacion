using System;
namespace Veterinario
{
    public class Program
    {
        public static void Main()
        {
            List<Visit> visits = new List<Visit>();
            visits.Add(new Visit(new Owner("12345678A", "Barack", "Obama", 123456789), new Pacient("Adolf", "German Shepherd", 5, true), DateTime.Now, "Checkup"));
            visits.Add(new Visit(new Owner("87654321B", "Pablo", "Marmol", 987654321), new Pacient("Rex", "Bulldog", 3, false), DateTime.Now, "Vomits"));
            visits.Add(new Visit(new Owner("11111111C", "Pol", "Robledillo", 111111111), new Pacient("Dino", "Chihuahua", 1, true), DateTime.Now, "Checkup"));
            visits.Add(new Visit(new Owner("22222222D", "Betty", "Marmol", 222222222), new Pacient("Lulu", "Poodle", 2, false), DateTime.Now, "Checkup"));
            visits.Add(new Visit(new Owner("33333333E", "Tom", "Hanks", 333333333), new Pacient("Wilson", "Ball", 3, false), DateTime.Now, "Air loss"));
            
            foreach (Visit visit in visits)
            {
                Console.WriteLine(visit);
                Console.WriteLine();
            }
        }
    }
}