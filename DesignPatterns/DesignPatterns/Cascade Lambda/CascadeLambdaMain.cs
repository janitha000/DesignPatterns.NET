using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cascade_Lambda
{
    class CascadeLambdaMain
    {
        static void Main(string[] args)
        {
            Mail.Send(mail => mail
            .To()
            .By()
            .CC()
            .Body());
        }

    }
}
