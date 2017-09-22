﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC
{
    class SamsungPhone : IPhone
    {
        public void Speak()
        {
            Console.WriteLine("Samsung calling");
        }
    }
}
