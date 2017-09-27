using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AroundWithLambda
{
    class AroundMain
    {
        static void Main(string[] args)
        {
            Database.Create(database =>
            {
                database.Query1();
                database.Query2();
            });

        }
    }
}
