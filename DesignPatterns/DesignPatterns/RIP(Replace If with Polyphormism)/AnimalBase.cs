using DesignPatterns.RIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP_Replace_If_with_Polyphormism_
{
    abstract class AnimalBase : IAnimal
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }
        public abstract void Bark();

        public IAnimal Clone()
        {
            return (IAnimal)this.MemberwiseClone();
        }
    }
}
