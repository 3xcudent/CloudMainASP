using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudMainASP.CloudMianASPTest
{

    public class plikj : CloudMainTest
    {


        public double Odejmowanie(double a, double b)
        {
            return (a - b);
        }

        public double Delta(double a, double b, double c)
        {
            return ((b * b) - 4 * a * c);
        }
        public double PoleTrojkata(double a, double b)
        {
            return ((a * b) / 2);
        }

    }
}
