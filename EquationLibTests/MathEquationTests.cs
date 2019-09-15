using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace EquationLibTests
{
    [TestClass]
    public class MathEquationTests
    {
        [TestMethod]
        public void SolveEquation_AllCoefficientsAreNotZeroAndSolutionExists_ReturnsTwoRoots()
        {
            //arrange
            double a = 3, b = -14, c = -5;
            double[] expected = { 5, (double)-1/3 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_AllCoefficientsAreZero_ReturnsEmptyArray()
        {
            //arrange
            double a = 0, b = 0, c = 0;
            double[] expected = { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_AIsZero_ReturnsOneRoot()
        {
            //arrange
            double a = 0, b = 7, c = -9;
            double[] expected = { (double)9/7 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_BIsZeroAndRootsDontExist_ReturnsEmptyArray()
        {
            //arrange
            double a = 7, b = 0, c = 7;
            double[] expected = { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_BIsZeroAndRootsExist_ReturnsTwoRoots()
        {
            //arrange
            double a = 7, b = 0, c = -7;
            double[] expected = { 1, -1 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_CIsZero_ReturnsZeroAndOtherRoot()
        {
            //arrange
            double a = 10, b = 2, c = 0;
            double[] expected = { 0, (double)-4/20 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_AAndBAreZero_ReturnsEmptyArray()
        {
            //arrange
            double a = 0, b = 0, c = 9;
            double[] expected = { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_AAndCAreZero_ReturnsZero()
        {
            //arrange
            double a = 0, b = 8, c = 0;
            double[] expected = { 0 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_BAndCAreZero_ReturnsZero()
        {
            //arrange
            double a = 1.056, b = 0, c = 0;
            double[] expected = { 0 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolveEquation_AllCoefficientsAreNotZeroAndRootsDontExist_ReturnsEmptyArray()
        {
            //arrange
            double a = 6, b = 0.1, c = 53;
            double[] expected = { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
