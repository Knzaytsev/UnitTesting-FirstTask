using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_FirstTask
{
    public class MathEquation
    {
        private double a, b, c;
        public MathEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double[] SolveEquation()
        {
            if (a != 0)
                return SolveEquationDiscriminant();
            else if (b != 0)
                return SolveEquationLinear();
            return new double[] { };
        }

        private double[] SolveEquationLinear()
        {
            return new double[] { -c / b };
        }

        private double[] SolveEquationDiscriminant()
        {
            var result = new List<double>();
            double d = b * b - 4 * a * c;
            double x1 = 0;
            double x2 = 0;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                result.Add(x1);
                result.Add(x2);
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                result.Add(x1);
            }
            return result.ToArray();
        }
    }
}
