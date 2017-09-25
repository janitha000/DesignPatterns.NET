using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cascade
{
    class CascadeMain
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Talk();
            person.Walk();
            person.Sleep();
            person.Jump();

            new Person().Talk().Walk().Sleep().Jump();
        }
    }
}
