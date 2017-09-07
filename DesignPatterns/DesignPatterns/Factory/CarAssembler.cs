using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class CarAssembler
    {
        public void AssembleCar(ToyotaCarFactory factory)
        {
            ToyotaCar toyotaCar = factory.GetCar();
            Console.WriteLine($"Created car {toyotaCar.Name} with {toyotaCar.Enginecc} cc");
        }
    }
}
