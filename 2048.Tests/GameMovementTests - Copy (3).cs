using _2048.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2048.Tests
{
    [TestClass]
    public class GameUpMovementTests
    {
        [TestMethod]
        public void MoveUpToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|1|4|8|16|
---------
|4|4|16|32|
---------
|8|8|16|32|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesUp();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|2|2|4|8|
---------
|4|8|8|16|
---------
|8|8|32|64|
---------
|0|0|0|0|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }


        [TestMethod]
        public void MoveUpToNotMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|16|128|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesUp();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|16|128|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void SlideUpToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|0|0|0|1|
---------
|0|0|1|0|
---------
|0|1|2|4|
---------
|1|2|4|8|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesUp();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|1|1|1|
---------
|0|2|2|4|
---------
|0|0|4|8|
---------
|0|0|0|0|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }


        [TestMethod]
        public void MoveUpWithMultipleMergesTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|1|4|8|16|
---------
|4|4|16|32|
---------
|4|8|16|32|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesUp();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|2|2|4|8|
---------
|8|8|8|16|
---------
|0|8|32|64|
---------
|0|0|0|0|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void MoveDownToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|1|4|8|16|
---------
|4|4|16|32|
---------
|8|8|16|32|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesDown();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|0|0|0|0|
---------
|2|2|4|8|
---------
|4|8|8|16|
---------
|8|8|32|64|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }


        [TestMethod]
        public void MoveDownToNotMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|16|128|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesDown();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|16|128|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void SlideDownToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|0|1|2|4|
---------
|0|0|1|0|
---------
|0|0|0|1|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesDown();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|0|0|0|0|
---------
|0|0|4|8|
---------
|0|2|2|4|
---------
|1|1|1|1|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void MoveRightToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|1|4|4|16|
---------
|4|4|16|32|
---------
|8|16|32|32|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesRight();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|0|1|8|16|
---------
|0|8|16|32|
---------
|0|8|16|64|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }


        [TestMethod]
        public void MoveRightToNotMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|32|128|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesRight();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|32|128|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void SlideRightToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|0|0|0|
---------
|2|1|0|0|
---------
|4|2|1|0|
---------
|8|4|0|1|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesRight();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|0|0|0|1|
---------
|0|0|2|1|
---------
|0|4|2|1|
---------
|0|8|4|1|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void MoveLeftToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|2|4|8|8|
---------
|4|16|16|32|
---------
|8|8|32|64|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesLeft();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|2|4|16|0|
---------
|4|32|32|0|
---------
|16|32|64|0|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }


        [TestMethod]
        public void MoveLeftToNotMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|32|128|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesLeft();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|2|4|8|
---------
|2|4|8|16|
---------
|4|8|4|32|
---------
|8|16|32|128|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

        [TestMethod]
        public void SlideLeftToMergeTest()
        {
            //Arrange
            string initialBoard = @"
---------
|0|0|0|1|
---------
|0|0|1|2|
---------
|0|1|2|4|
---------
|1|0|4|8|
---------
";
            Game game = new(initialBoard);

            //Act
            game.MovePiecesLeft();
            string gameBoardCurrent = game.ToString();

            //Assert
            string gameBoardExpected = @"
---------
|1|0|0|0|
---------
|1|2|0|0|
---------
|1|2|4|0|
---------
|1|4|8|0|
---------
";
            Assert.AreEqual(gameBoardExpected, gameBoardCurrent);
        }

    }
}