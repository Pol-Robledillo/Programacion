using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex13
    {
        public static void Main()
        {
            //Landing System
            ExpertSystem expertSystem = new ExpertSystem();
            LandingSystem landingSystem = new LandingSystem(expertSystem);

            //Board Computer
            AI ai = new AI();
            BoardComputer boardComputer = new BoardComputer(ai);

            //Navigation System
            NavigationSystem navigationSystem = new NavigationSystem();

            //Rocket
            Motor motor1 = Motor.Build(1234);
            Motor motor2 = Motor.Build(4321);
            Rocket rocket = new Rocket(motor1, motor2, 1000, 0);

            //SpaceShip
            SpaceShip spaceShip = new SpaceShip(landingSystem, boardComputer, navigationSystem, rocket);
            
            //Crew
            Astronaut astronaut = new Astronaut("John", "Doe", 30);
            SubCommander subCommander = new SubCommander("Jane", "Doe", 40);
            spaceShip.AddCrewMember(astronaut);
            spaceShip.AddCrewMember(subCommander);

            //Tests
            spaceShip.PilotedBy(subCommander);
            spaceShip.BoardComputer.AI.IsFunctional = false;
            spaceShip.PilotedBy(subCommander);
            spaceShip.PilotedBy(astronaut);

            spaceShip.Rocket.Motor1.Start(1234, 1000);
            spaceShip.Rocket.Motor1.Start(4321, 1000);
            spaceShip.Rocket.Motor1.Start(1234, 0);

            spaceShip.Rocket.ChangeDirection(spaceShip.NavigationSystem.CalcAngle());
        }
    }
}