using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class SpaceShip : IFlyable
    {
        public LandingSystem? LandingSystem { get; set; }
        public BoardComputer BoardComputer { get; set; }
        public NavigationSystem NavigationSystem { get; set; }
        public Rocket Rocket { get; set; }
        public ArrayList Crew { get; set; }
        public SpaceShip(LandingSystem landingSystem, BoardComputer boardComputer, NavigationSystem navigationSystem, Rocket rocket)
        {
            LandingSystem = landingSystem;
            BoardComputer = boardComputer;
            NavigationSystem = navigationSystem;
            Rocket = rocket;
            Crew = new ArrayList();
        }
        public void AddCrewMember(Astronaut crewMember)
        {
            Crew.Add(crewMember);
        }
        public void AddCrewMember(SubCommander crewMember)
        {
            Crew.Add(crewMember);
        }
        public void PilotedBy(object pilot)
        {
            if (BoardComputer.AI.IsFunctional)
            {
                Console.WriteLine("Piloted by the AI");
            }
            else
            {
                if (pilot is SubCommander)
                {
                    Console.WriteLine("Piloted by the SubCommander");
                }
                else
                {
                    Console.WriteLine("That crew member cannot pilot the spaceship");
                }
            }
        }
    }
}
