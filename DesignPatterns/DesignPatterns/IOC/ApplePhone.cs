using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC
{
    class ApplePhone : IPhone
    {
        public void Speak()
        {
            Console.WriteLine("IPhone calling");
        }
    }
}
