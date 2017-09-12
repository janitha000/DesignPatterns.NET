using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
}
