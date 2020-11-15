namespace MarsRover
{
    public class Plateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Width and height of the Plateau
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Plateau(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}