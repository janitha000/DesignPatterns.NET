using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factories
{
    public class CommonCarFactory : ToyotaCarFactory
    {
        public override ToyotaCar GetCar()
        {
            throw new NotImplementedException();
        }

        public override ToyotaCar GetCar(string type)
        {
            switch (type)
            {
                case "Allion":
                    return new Allion();
                case "Corolla":
                    return new Corolla();
                default:
                    return null;
            }
        }
    }
}
