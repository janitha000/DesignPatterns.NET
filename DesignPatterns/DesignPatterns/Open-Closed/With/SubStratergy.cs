using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed.With
{
    class SubStratergy : IStratergy
    {
        public decimal Calculate(Order order)
        {
            return order.ValueOne - order.ValueTwo;
        }

        public bool isMatch(Order order)
        {
            return order.Type.Equals("sub");
        }
    }
}
