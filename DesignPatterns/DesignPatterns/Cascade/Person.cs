using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cascade
{
    class Person
    {
        //public void Talk()
        //{
        //    Console.WriteLine("Hello");
        //}

        //public void Sleep()
        //{
        //    Console.WriteLine("zzzzzzzzzz");
        //}

        //public void Walk()
        //{
        //    Console.WriteLine("1 2 3 ");
        //}

        //public void Jump()
        //{
        //    Console.WriteLine("Higerrrrrrrr");
        //}

        public Person Talk()
        {
            Console.WriteLine("Hello");
            return this;
        }

        public Person Sleep()
        {
            Console.WriteLine("Hello");
            return this;
        }

        public Person Walk()
        {
            Console.WriteLine("Hello");
            return this;
        }

        public Person Jump()
        {
            Console.WriteLine("Hello");
            return this;
        }
    }
}
