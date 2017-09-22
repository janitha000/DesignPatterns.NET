using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject
{
    class AnimalFactory
    {
        public IAnimal GetAnimal(string type)
        {
            IAnimal animal = NullAnimal.instance;
            if (type == "cat")
                return new Cat();
            return animal;
        }
    }
}
