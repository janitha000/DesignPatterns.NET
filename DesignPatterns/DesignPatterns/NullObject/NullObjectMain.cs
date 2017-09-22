using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject
{
    class NullObjectMain
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();

            IAnimal cat = factory.GetAnimal("cat");
            cat.Speak();

            IAnimal dog = factory.GetAnimal("dog");
            dog.Speak();
        }
    }
}
