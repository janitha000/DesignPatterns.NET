using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    interface ITimeCategory
    {
        string Time { get; set; }
        string ToDays();

        string Accept(IVisitor visitor);
    }
}
