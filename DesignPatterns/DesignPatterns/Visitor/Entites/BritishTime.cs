using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class BritishTime : ITimeCategory
    {
        private string _time;
        public string Time { get => _time; set => _time = value; }

        public string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public string ToDays()
        {
            return Time;
        }
    }
}
