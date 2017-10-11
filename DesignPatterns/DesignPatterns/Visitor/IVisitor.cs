using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    interface IVisitor
    {
        string Visit(SinhalaTime time);
        string Visit(ChineseTime time);
        string Visit(BritishTime time);

    }
}
