using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTest
{
    [TestClass]
    public class RoverTest
    {
        private Rover firstRover = new Rover(new Plateau(5, 5), 1, 2, Rover.Direction.N);
        private Rover secondRover = new Rover(new Plateau(5, 5), 3, 3, Rover.Direction.E);


        /// <summary>
        /// Correct assertion 
        /// </summary>
        [TestMethod]
        public void Test_12N_LMLMLMLMM()
        {
            firstRover.Command("LMLMLMLMM");
            Assert.AreEqual(firstRover.GetPosition(), "1 3 N");
        }

        /// <summary>
        /// Wrong assertion
        /// </summary>
        [TestMethod]
        public void Test_33E_MRRMMRMRRM()
        {
            secondRover.Command("MMRMMRMRRM");
            Assert.AreNotEqual(secondRover.GetPosition(), "1 3 N");
        }
    }
}
