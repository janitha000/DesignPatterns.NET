using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP
{
    class RIPMain
    {
        static void Main(string[] args)
        {

            IAnimal cat = AnimalFactory.Create(0);
            cat.Bark();

            IAnimal dog = AnimalFactory.Create(1);
            dog.Bark();
        }
    }
}
