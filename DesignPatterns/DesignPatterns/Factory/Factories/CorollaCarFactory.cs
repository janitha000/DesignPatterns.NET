using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factories
{
    class CorollaCarFactory : ToyotaCarFactory
    {
        public override ToyotaCar GetCar()
        {
            return new Corolla();
        }
    }
}
