﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class FactoryMain
    {
        static void Main(string[] args)
        {
            ToyotaCarFactory factory = new AllionCarFactory();
            new CarAssembler().AssembleCar(factory);
        }
    }
}
