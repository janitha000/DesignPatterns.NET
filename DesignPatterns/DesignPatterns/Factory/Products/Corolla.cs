using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Corolla : ToyotaCar
    {
        public override int Enginecc
        {
            get
            {
                return 1600;
            }
        }

        public override string Name
        {
            get
            {
                return "Corolla";
            }
        }
    }
}
