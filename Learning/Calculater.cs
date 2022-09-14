using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Calculater
    {
        public bool TryDivide (double divisible,double divisor, out double result)
        {

            result = 0;
            if (divisor ==0)
            {
                return false;

            }
            result = divisible / divisor;
            return true;
        }

        public static double Average (int[]numbers)
        {
            int sum = 0;    
            foreach(int n in numbers)
            {

                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        public static double Average2(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {

                sum += n;
            }
            return (double)sum / numbers.Length;

        }

        public double Calculater11(double a, double b, double c)
        {

            double P = (a + b + c) / 2;

            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            
        }
        public double Calculater11(double b, double h)
        {



            return 0.5 * b * h;

        }


    }
}
