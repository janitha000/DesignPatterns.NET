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
            AnimalFactory factory = new AnimalFactory();

            IAnimal cat = factory.Create(0);
            cat.Bark();

            IAnimal dog = factory.Create(1);
            dog.Bark();
        }
    }
}
