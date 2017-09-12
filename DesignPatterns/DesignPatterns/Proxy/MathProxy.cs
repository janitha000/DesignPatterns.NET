using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class MathProxy : IMath
    {
        private Math _math = new Math();
        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }

        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
    }
}
