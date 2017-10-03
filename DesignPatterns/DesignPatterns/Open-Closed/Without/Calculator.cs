using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed
{
    class Calculator
    {
        public decimal Calculate(Order order)
        {
            string type = order.Type;
            decimal valueOne = order.ValueOne;
            decimal valueTwo = order.ValueTwo;

            if (type.Equals("add"))
            {
                return valueOne + valueTwo;
            }
            else if (type.Equals("sub"))
            {
                return valueOne - valueTwo;
            }
            else if (type.Equals("mul"))
            {
                return valueOne * valueTwo;
            }
            else if (type.Equals("div"))
            {
                return valueOne / valueTwo;
            }
            else
                return 0;

        }
    }
}
