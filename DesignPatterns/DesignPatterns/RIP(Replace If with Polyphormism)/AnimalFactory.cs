using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP
{
    class AnimalFactory
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public AnimalFactory()
        {
            animals.Add(new Cat());
            animals.Add(new Dog());
        }

        public IAnimal Create(int animalType)
        {
            return animals[animalType];
        }

        //public IAnimal Create(int animalType)
        //{
        //    if (animalType == 1)
        //        return new Cat();
        //    if (animalType == 2)
        //        return new Dog();
        //}
    }
}
