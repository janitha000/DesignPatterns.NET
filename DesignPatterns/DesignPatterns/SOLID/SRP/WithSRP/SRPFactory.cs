using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.SRP
{
    abstract class SRPFactory
    {
        private Phone _phone;

        public SRPFactory(Phone phone)
        {
            Console.WriteLine("Phone created from raw material");
            _phone = phone;
        }

        public Phone phone
        {
            get
            {
                return _phone;
            }
        }

        public virtual void GetPhone()
        {

        }


    }
}
