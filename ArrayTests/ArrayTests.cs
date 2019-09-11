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
            string input = "1.2, 2, 3.5";
            double[] expectedArray = new double[] { 1.2, 2, 3.5 };
            double[] result = WorkArray.FormingArray(input);
            CollectionAssert.AreEqual(expectedArray, result);
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
    }
}
