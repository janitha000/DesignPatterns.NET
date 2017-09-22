using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject
{
    class Cat : IAnimal
    {
        public void Sleep()
        {
            Console.WriteLine("Prrr Prr");
        }

        public void Speak()
        {
            Console.WriteLine("Chaaw Chaaw");
        }
    }
}
