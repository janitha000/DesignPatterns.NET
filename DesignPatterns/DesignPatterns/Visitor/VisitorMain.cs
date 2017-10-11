using DesignPatterns.Visitor.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class VisitorMain
    {
        static void Main(string[] args)
        {
            SinhalaTime sTime = new SinhalaTime();
            Console.WriteLine(sTime.ToDays());
            Console.WriteLine(sTime.Accept(new SecondsVisitor()));
        }
    }
}
