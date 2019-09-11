using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayClassLibraryTests;

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
            WorkArray workArray = new WorkArray();
        }
    }
}
