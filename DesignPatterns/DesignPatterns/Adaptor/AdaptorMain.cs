using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adaptor
{
    class AdaptorMain
    {
        static void Main(string[] args)
        {
            Animal animal = new Adaptor();
            animal.Talk();
        }
    }
}
