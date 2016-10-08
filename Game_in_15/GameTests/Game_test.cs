using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameIn15;
namespace GameTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckСreationField_ShouldThrowExceptionWhenPassInvalidArgs()
        {
            Game myGame= new Game(0,7,8,0,80);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Shift_ShouldThrowExceptionWhenPassInvalidArgs()
        {
            Game myGame = new Game(0, 7, 8, 1, 2,3,4,5,6);

            myGame.Shift(6);
        }
        [TestMethod]
        public void Shift_ShouldThrowPass()
        {
            Game myGame = new Game(0, 7, 8, 1, 2, 3, 4, 5, 6);
            myGame.Shift(1);
            Assert.AreEqual(myGame[0,0], 1);
            Assert.AreEqual(myGame[1, 0], 0);
        }
        [TestMethod]
      
        public void ThisTest()
        {
            Game myGame = new Game(0, 7, 8, 1, 2, 3, 4, 5, 6);
            Assert.AreEqual(myGame[0,0], 0);

        }
        [TestMethod]

        public void GetLocation_ShouldThrowPass()
        {
            Game myGame = new Game(0, 7, 8, 1, 2, 3, 4, 5, 6);
            Game.Point result = myGame.GetLocation(4);
            Assert.AreEqual(result.x, 2);
            Assert.AreEqual(result.y, 0);
        }
    }
}
