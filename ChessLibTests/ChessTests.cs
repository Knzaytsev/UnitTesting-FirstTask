using System;
using Chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessLibTests
{
    [TestClass]
    public class ChessTests
    {
        [TestMethod]
        public void CheckBeat_SameHorizontalBetweenTwoQueens_ReturnsTrue()
        {
            //arrange
            int[,] queens = { { 3, 5 }, { 3, 8 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBeat_SameVerticalBetweenFirstAndThirdQueens_ReturnsTrue()
        {
            //arrange
            int[,] queens = { { 3, 5 }, { 1, 8 }, { 8, 5 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBeat_SameDiagonalBetweenTwoQueens_ReturnsTrue()
        {
            //arrange
            int[,] queens = { { 3, 2 }, { 8, 7 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBeat_AllQueensDontIntersect_ReturnsFalse()
        {
            //arrange
            int[,] queens = { { 1, 4 }, { 2, 6 }, { 3, 8 }, { 4, 5 }, { 5, 7 }, { 6, 1 }, { 7, 3 } };
            bool expected = false;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SameElementException))]
        public void CheckBeat_SameLocationBetweenTwoQueens_ThrowsSameElementException()
        {
            //arrange
            int[,] queens = { { 1, 4 }, { 1, 8 },  { 1, 4 } };

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);

            //assert
            //assert.Failed()
        }

        [TestMethod]
        public void CheckBeat_FirstQueenIntersectsSecondInTheEnd_ReturnsTrue()
        {
            //arrange
            int[,] queens = { { 1, 4 }, { 2, 6 }, { 3, 8 }, { 4, 5 }, { 5, 7 }, { 6, 1 }, { 8, 4 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBeat_AllQueensIntersect_ReturnsTrue()
        {
            //arrange
            int[,] queens = { { 6, 7 }, { 7, 8 }, { 6, 1 }, { 2, 8 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
