using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject
{
    class NullAnimal : IAnimal
    {
        private static NullAnimal _instance;

        private NullAnimal() { }

        public static NullAnimal instance
        {
            get
            {
                if (_instance == null)
                    return new NullAnimal();
                return _instance;
            }
        }


        public void Sleep()
        {
        }

        public void Speak()
        {
        }
    }
}
