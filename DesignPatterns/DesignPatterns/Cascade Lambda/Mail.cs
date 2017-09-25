using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cascade_Lambda
{
    class Mail
    {
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

        public static void Send(Action<Mail> action)
        {
            action(new Mail());
            Console.WriteLine("Mail Sent!!!");
        }
    }
}
