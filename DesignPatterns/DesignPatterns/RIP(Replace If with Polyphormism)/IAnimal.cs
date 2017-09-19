using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RIP
{
    interface IAnimal
    {
        string Type { get; set; }
        int Age { get; set; }
        string Sound { get; set; }
        void Bark();
    }
}
