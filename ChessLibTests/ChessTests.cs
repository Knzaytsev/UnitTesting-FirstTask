using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace ChessLibTests
{
    [TestClass]
    public class ChessTests
    {
        [TestMethod]
        public void ChessTest()
        {
            int[,] queens = new int[,] { { 2, 1 }, { 3, 3 } };
            bool expected = false;
            Chess chess = new Chess(queens);
            bool result = chess.CheckBeat();
            Assert.AreEqual(expected, result);
        }
    }
}
