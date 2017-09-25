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
            Mail person = new Mail();

            person.To();
            person.By();
            person.CC();
            person.Body();
            person.Send();

            new Mail().To().By().CC().Body().Send();
        }
    }
}
