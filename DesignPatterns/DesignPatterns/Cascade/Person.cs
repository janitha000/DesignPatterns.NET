using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cascade
{
    class Mail
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

        public Mail To()
        {
            Console.WriteLine("To");
            return this;
        }

        public Mail By()
        {
            Console.WriteLine("By");
            return this;
        }

        public Mail Body()
        {
            Console.WriteLine("Body");
            return this;
        }

        public Mail CC()
        {
            Console.WriteLine("CC");
            return this;
        }

        public void Send()
        {
            Console.WriteLine("Mail Sent!!!");
        }
    }
}
