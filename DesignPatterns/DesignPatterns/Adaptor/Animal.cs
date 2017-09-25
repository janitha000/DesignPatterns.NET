using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adaptor
{
    class Animal
    {
        public virtual void Talk()
        {
            Console.WriteLine("Baw Baw");
        }
    }
}
