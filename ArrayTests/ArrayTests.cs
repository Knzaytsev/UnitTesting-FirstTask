using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace ArrayClassLibraryTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void FormingArrayTest()
        {
            int countTest = 2;
            string[] testStrings = new string[] { "1.2, 2, 3.5", "-1", "" };
            /*string input = "1.2, 2, 3.5";
            double[] expectedArray = new double[] { 1.2, 2, 3.5 };
            double[] result = WorkArray.FormingArray(input);*/
            double[][] result = new double[countTest][];
            double[][] expectedArrays = new double[][] { new double[] { 1.2, 2, 3.5 }, new double[] { -1 }, new double[] { } };
            for (int i = 0; i < countTest; ++i)
            {
                result[i] = WorkArray.FormingArray(testStrings[i]);
            }
            for (int i = 0; i < countTest; ++i)
            {
                CollectionAssert.AreEqual(expectedArrays[i], result[i]);
            }
        }

        [TestMethod]
        public void RemoveTest()
        {
            int element = 2;
            double[] inputArray = new double[] { 2, 1, 3, 4, 5 };
            double[] expectedArray = new double[] { 2, 3, 5 };
            double[] result = WorkArray.Remove(element, inputArray);
            CollectionAssert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void EquationTest()
        {
            int countTest = 2;
            double[][] inputValues = new double[][] { new double[] { 3, -14, -5 }, new double[] { 0, 0, 0 } };
            double[][] expectedValues = new double[][] { new double[] { 5, (double)-1 / 3 }, new double[] { } };
            double[][] result = new double[countTest][];
            for (int i = 0; i < countTest; ++i)
            {
                double a = inputValues[i][0];
                double b = inputValues[i][1];
                double c = inputValues[i][2];
                MathEquation equation = new MathEquation(a, b, c);
                result[i] = equation.SolveEquation();
            }
            for (int i = 0; i < countTest; ++i)
            {
                CollectionAssert.AreEqual(expectedValues[i], result[i]);
            }
            /*double a = 3, b = -14, c = -5;
            double[] expected = new double[] { 5, (double)-1/3 };
            MathEquation equation = new MathEquation(a, b, c);
            double[] result = equation.SolveEquation();
            CollectionAssert.AreEqual(expected, result);*/
        }
    }
}
