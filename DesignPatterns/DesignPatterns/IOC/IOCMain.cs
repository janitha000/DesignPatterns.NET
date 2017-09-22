using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC
{
    class IOCMain
    {
        static void Main(string[] args)
        {
            //Look inside Communication class for IOC

            Communication comm = new Communication(new ApplePhone());
            comm.Speak();
        }
    }
}
