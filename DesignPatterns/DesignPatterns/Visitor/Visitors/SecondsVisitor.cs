using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Visitors
{
    class SecondsVisitor : IVisitor
    {
        public string Visit(SinhalaTime time)
        {
            return "Converted to seconds";
        }

        public string Visit(ChineseTime time)
        {
            return "Converted to seconds";
        }

        public string Visit(BritishTime time)
        {
            return "Converted to seconds";
        }
    }
}
