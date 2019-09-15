using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_FirstTask
{
    public class WorkArray
    {
        public double[] FormingArray(string str)
        {
            string[] parsedString = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var arr = new double[parsedString.Length];
            for (var i = 0; i < arr.Length; ++i)
            {
                try
                {
                    arr[i] = double.Parse(parsedString[i], System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                }
                catch
                {
                    throw new WrongInputStringException();
                }
            }
            return arr;
        }

        public double[] Remove(int element, double[] arr)
        {
            if (element <= 0)
                throw new MinusElementException();
            int length = arr.Length;
            var newArr = new List<double>();
            for (var i = 0; i < length; ++i)
            {
                if((i + 1) % element != 0)
                {
                    newArr.Add(arr[i]);
                }
            }
            return newArr.ToArray();
        }
    }
}
