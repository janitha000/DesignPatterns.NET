using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class ProxyMain
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Multiply(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Divide(4, 2));
        }
    }
}
