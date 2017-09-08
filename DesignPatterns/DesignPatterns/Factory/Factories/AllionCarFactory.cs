using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class AllionCarFactory : ToyotaCarFactory
    {
        public override ToyotaCar GetCar()
        {
            return new Allion();
        }

        public override ToyotaCar GetCar(string type)
        {
            throw new NotImplementedException();
        }
    }
}
