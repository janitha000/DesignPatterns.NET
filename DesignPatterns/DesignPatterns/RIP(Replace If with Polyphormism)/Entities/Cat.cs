using DesignPatterns.RIP_Replace_If_with_Polyphormism_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP
{
    class Cat : AnimalBase
    {
        public override void Bark()
        {
            Console.WriteLine("chaaw chaaw");
        }
    }
}
