using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_FirstTask;

namespace ArrayClassLibraryTests
{
    [TestClass]
    public class WorkArrayTests
    {
        [TestMethod]
        public void Forming_zero_elements_test()
        {
            //arrange
            string str = "";
            double[] expected = new double[] { };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forming_three_elements_with_positive()
        {
            //arrange
            string str = "1.2, 2, 3.5";
            double[] expected = new double[] { 1.2, 2, 3.5 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forming_one_element_with_negative()
        {
            //arrange
            string str = "-1";
            double[] expected = new double[] { -1 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forming_two_elements_with_negative_and_positive()
        {
            //arrange
            string str = "-6.75, 23";
            double[] expected = new double[] { -6.75, 23 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forming_five_positive_elements_without_point()
        {
            //arrange
            string str = "999, 19865, 23248, 231, 8952";
            double[] expected = new double[] { 999, 19865, 23248, 231, 8952 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forming_six_negative_elements_without_point()
        {
            //arrange
            string str = "-89, -23, -898, -78, -88, -89";
            double[] expected = new double[] { -89, -23, -898, -78, -88, -89 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.FormingArray(str);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongInputStringException))]
        public void Forming_with_exception()
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
        public void Remove_minus_element()
        {
            //arrange
            int element = -6;
            double[] array = new double[] { 1, 5, 1 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            //assert.Failed()
        }

        [TestMethod]
        public void Remove_in_empty_array()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { };
            double[] expected = new double[] { };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_second_element_without_point()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { 2, 1, 3, 4, 5 };
            double[] expected = new double[] { 2, 3, 5 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_second_element_with_point()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { 2.2, 1.846, 989.41 };
            double[] expected = new double[] { 2.2, 989.41 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_second_element_in_even_array()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { 95, -89, 23158, 23.58899, 22166485, -982.21 };
            double[] expected = new double[] { 95, 23158, 22166485 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_one_element()
        {
            //arrange
            int element = 1;
            double[] array = new double[] { 56, 98.23, 784 };
            double[] expected = new double[] {  };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_second_element_in_array_with_one_element()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { 852 };
            double[] expected = new double[] { 852 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_last_element()
        {
            //arrange
            int element = 2;
            double[] array = new double[] { 8965.5238, -7523 };
            double[] expected = new double[] { 8965.5238 };

            //act
            WorkArray workArray = new WorkArray();
            double[] actual = workArray.Remove(element, array);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
