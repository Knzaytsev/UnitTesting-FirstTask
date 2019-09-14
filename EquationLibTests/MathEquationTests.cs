﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace EquationLibTests
{
    [TestClass]
    public class MathEquationTests
    {
        [TestMethod]
        public void all_not_zero_coeffs()
        {
            //arrange
            double a = 3, b = -14, c = -5;
            double[] expected = new double[] { 5, (double)-1/3 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void all_zero_coeffs()
        {
            //arrange
            double a = 0, b = 0, c = 0;
            double[] expected = new double[] { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void a_is_zero()
        {
            //arrange
            double a = 0, b = 7, c = -9;
            double[] expected = new double[] { (double)9/7 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void b_is_zero_and_no_roots()
        {
            //arrange
            double a = 7, b = 0, c = 7;
            double[] expected = new double[] { };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void b_is_zero()
        {
            //arrange
            double a = 7, b = 0, c = -7;
            double[] expected = new double[] { 1, -1 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void c_is_zero()
        {
            //arrange
            double a = 10, b = 2, c = 0;
            double[] expected = new double[] { 0, (double)-4/20 };

            //act
            MathEquation equation = new MathEquation(a, b, c);
            double[] actual = equation.SolveEquation();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}
