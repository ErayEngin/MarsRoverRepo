using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM");

            var firstRover = new Rover(new Plateau(5, 5), 1, 2, Rover.Direction.N);
            firstRover.Command("LMLMLMLMM");

            var secondRover = new Rover(new Plateau(5, 5), 3, 3, Rover.Direction.E);
            secondRover.Command("MMRMMRMRRM");

            Console.WriteLine("\nOutput");

            firstRover.GetPosition();
            secondRover.GetPosition();

            Console.ReadLine();
        }
    }
}
