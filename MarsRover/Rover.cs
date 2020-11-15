using System;

namespace MarsRover
{
    public class Rover
    {

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        Direction RoverDirection { get; set; }
        Plateau Plateau { get; set; }

        /// <summary>
        /// Shows the direction of the rover 
        /// </summary>
        public enum Direction
        {
            N = 90,
            E = 180,
            S = 270,
            W = 360
        }

        /// <summary>
        /// Constructor of the class 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        /// <param name="plateau"></param>
        public Rover(Plateau plateau, int x, int y, Direction direction)
        {
            PositionX = x;
            PositionY = y;
            RoverDirection = direction;
            Plateau = plateau;
        }

        /// <summary>
        /// Movements of rover based on direction
        /// </summary>
        private void Go()
        {
            if (RoverDirection == Direction.N && Plateau.Y > PositionY)
            {
                PositionY++;
            }
            else if (RoverDirection == Direction.E && Plateau.X > PositionX)
            {
                PositionX++;
            }
            else if (RoverDirection == Direction.S && PositionY > 0)
            {
                PositionY--;
            }
            else if (RoverDirection == Direction.W && PositionX > 0)
            {
                PositionX--;
            }
        }

        /// <summary>
        /// Change the direction of the rover
        /// </summary>
        /// <param name="directionCode"></param>
        private void ChangeDirection(char directionCode)
        {
            if (directionCode == 'L')
                RoverDirection = (RoverDirection - 90) < Direction.N ? Direction.W : RoverDirection - 90;
            else if (directionCode == 'R')
                RoverDirection = (RoverDirection + 90) > Direction.W ? Direction.N : RoverDirection + 90;
        }

        /// <summary>
        /// Process the command string
        /// </summary>
        /// <param name="commandStr"></param>
        public void Command(string commandStr)
        {
            foreach (var command in commandStr)
            {
                if (command == 'L' || command == 'R')
                    ChangeDirection(command);
                else if (command == 'M')
                    Go();
            }
        }

        /// <summary>
        /// Get position and direction of the cover at the end of the command
        /// </summary>
        public string GetPosition()
        {
            string printedRoverPosition = string.Format("{0} {1} {2}", PositionX, PositionY, RoverDirection);
            Console.WriteLine(printedRoverPosition);
            return printedRoverPosition;
        }
    }
}