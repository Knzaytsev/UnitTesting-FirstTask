using System;
using Chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessLibTests
{
    [TestClass]
    public class ChessTests
    {
        [TestMethod]
        public void equal_x()
        {
            //arrange
            int[,] queens = new int[,] { { 3, 5 }, { 3, 8 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void equal_y()
        {
            //arrange
            int[,] queens = new int[,] { { 3, 5 }, { 1, 8 }, { 8, 5 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void equal_diag()
        {
            //arrange
            int[,] queens = new int[,] { { 3, 2 }, { 8, 7 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void not_beat()
        {
            //arrange
            int[,] queens = new int[,] { { 1, 4 }, { 2, 6 }, { 3, 8 }, { 4, 5 }, { 5, 7 }, { 6, 1 }, { 7, 3 } };
            bool expected = false;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SameElementException))]
        public void equal_location_two_queens()
        {
            //arrange
            int[,] queens = new int[,] { { 1, 4 }, { 1, 8 },  { 1, 4 } };

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);

            //assert
            //assert.Failed()
        }

        [TestMethod]
        public void beat_in_the_end()
        {
            //arrange
            int[,] queens = new int[,] { { 1, 4 }, { 2, 6 }, { 3, 8 }, { 4, 5 }, { 5, 7 }, { 6, 1 }, { 8, 4 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void all_beat()
        {
            //arrange
            int[,] queens = new int[,] { { 6, 7 }, { 7, 8 }, { 6, 1 }, { 2, 8 } };
            bool expected = true;

            //act
            UnitTesting_FirstTask.Chess chess = new UnitTesting_FirstTask.Chess(queens);
            bool actual = chess.CheckBeat();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
