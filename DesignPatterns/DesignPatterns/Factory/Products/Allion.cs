using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Allion : ToyotaCar
    {
        public override int Enginecc
        {
            get
            {
                return 1500;
            }
        }

        public override string Name
        {
            get
            {
                return "Allion";
            }
        }
    }
}
