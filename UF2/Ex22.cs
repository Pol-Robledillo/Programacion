using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr22
    {
        public static void Main()
        {
            double positionX = 0, positionY = 0;
            int direction = 45, time = 0;
            const int UpdatePos = 1, Duration = 5, Speed = 1;
            const string MsgShowPos = "Al segón {0} es troba a la posició X:{1} Y:{2}";

            Random directionChange = new Random();

            while (time < Duration)
            {
                positionX = CalcPositionX(positionX, Speed, direction);
                positionY = CalcPositionY(positionY, Speed, direction);

                time += UpdatePos;
                direction += directionChange.Next(3) == 1 ? 10 : -10;
                direction += 10;

                Console.WriteLine(MsgShowPos, time, positionX, positionY);
            }
        }
        public static double CalcPositionX(double positionX, int speed, int direction)
        {
            return positionX + (speed * (Math.Cos((direction * Math.PI) / 180)));
        }
        public static double CalcPositionY(double positionY, int speed, int direction)
        {
            return positionY + (speed * (Math.Sin((direction * Math.PI) / 180)));
        }
    }
}