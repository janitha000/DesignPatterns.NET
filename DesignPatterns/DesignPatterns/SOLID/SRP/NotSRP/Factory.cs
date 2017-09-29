using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.SRP
{
    class Factory
    {
        private Phone _phone;

        public void Create(Phone phone)
        {
            Console.WriteLine("Phone created from raw material");
            _phone = phone;
        }

        public void Assemble(Phone phone)
        {
            Console.WriteLine("Phone assembled");
            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("Assembling" + phone.Name);

            }
        }

        public void Deliver(List<Phone> phones)
        {
            Console.WriteLine("Phone delivered");
            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone.Name + "Delivered");
            }
        }
    }
}
