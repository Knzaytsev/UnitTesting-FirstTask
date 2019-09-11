using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_FirstTask
{
    public class WorkArray
    {
        public static double[] FormingArray(string str)
        {
            string[] parsedString = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] arr = new double[parsedString.Length];
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = double.Parse(parsedString[i], System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            return arr;
        }

        public static double[] Remove(int element, double[] arr)
        {
            int length = arr.Length;
            List<double> newArr = new List<double>();
            for (int i = 0; i < length; ++i)
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
