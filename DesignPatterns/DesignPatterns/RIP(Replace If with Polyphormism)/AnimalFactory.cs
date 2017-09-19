using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP
{
    static class AnimalFactory
    {
        private static List<IAnimal> animals = null;

        private static void LoadAnimals()
        {
            animals = new List<IAnimal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
        }

        public static IAnimal Create(int animalType)
        {
            if(animals == null)
            {
                LoadAnimals();
            }
            return animals[animalType].Clone();
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
