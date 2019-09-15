using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace ArrayClassLibraryTests
{
    [TestClass]
    public class WorkArrayTests
    {
        [TestMethod]
        public void FormingArray_StringIsEmpty_ReturnsEmptyArray()
        {
            //arrange
            string str = "";
            double[] expected = { };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormingArray_AllThreeElementsArePositiveInString_ReturnsSameElements()
        {
            //arrange
            string str = "1.2, 2, 3.5";
            double[] expected = { 1.2, 2, 3.5 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormingArray_OneElemenInStringIsNegativ_ReturnsSameElement()
        {
            //arrange
            string str = "-1";
            double[] expected = { -1 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormingArray_OneInStringElementIsNegativeOtherIsPositive_ReturnsSameElements()
        {
            //arrange
            string str = "-6.75, 23";
            double[] expected = { -6.75, 23 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormingArray_AllFiveElementsInStringArePositiveIntegers_ReturnsSameElements()
        {
            //arrange
            string str = "999, 19865, 23248, 231, 8952";
            double[] expected = { 999, 19865, 23248, 231, 8952 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormingArray_AllSixElementsInStringAreNegativeIntegers_ReturnsSameElements()
        {
            //arrange
            string str = "-89, -23, -898, -78, -88, -89";
            double[] expected = { -89, -23, -898, -78, -88, -89 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongInputStringException))]
        public void FormingArray_StringWithLetter_ThrowsWrongInputException()
        {
            //arrange
            string str = "1,5, 5.a, 8";

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            //assert.Failed()
        }

        [TestMethod]
        [ExpectedException(typeof(MinusElementException))]
        public void Remove_NegativeElementInArray_ThrowsMinusElementException()
        {
            //arrange
            int element = -6;
            double[] array = { 1, 5, 1 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            //assert.Failed()
        }

        [TestMethod]
        public void Remove_EmptyArray_ReturnsEmptyArray()
        {
            //arrange
            int element = 2;
            double[] array = { };
            double[] expected = { };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SecondElementInArrayWithPositiveFiveIntegers_ReturnsThreeElementsInArray()
        {
            //arrange
            int element = 2;
            double[] array = { 2, 1, 3, 4, 5 };
            double[] expected = { 2, 3, 5 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SecondElementInArrayWithPositiveFourFloats_ReturnsThreeElementsInArray()
        {
            //arrange
            int element = 2;
            double[] array = { 2.2, 1.846, 989.41 };
            double[] expected = { 2.2, 989.41 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SecondElementInEvenArray_ReturnsOddElements()
        {
            //arrange
            int element = 2;
            double[] array = { 95, -89, 23158, 23.58899, 22166485, -982.21 };
            double[] expected = { 95, 23158, 22166485 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_AllElementsInArray_ReturnsEmptyArray()
        {
            //arrange
            int element = 1;
            double[] array = { 56, 98.23, 784 };
            double[] expected = {  };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SecondElementInArrayWithOneElement_ReturnsSameArray()
        {
            //arrange
            int element = 2;
            double[] array = { 852 };
            double[] expected = { 852 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_LastElementInArray_ReturnsArrayWithoutLastElement()
        {
            //arrange
            int element = 2;
            double[] array = { 8965.5238, -7523 };
            double[] expected = { 8965.5238 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
