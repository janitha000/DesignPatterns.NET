using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }
    }
}
