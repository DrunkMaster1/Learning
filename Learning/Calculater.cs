using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Calculater
    {
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
