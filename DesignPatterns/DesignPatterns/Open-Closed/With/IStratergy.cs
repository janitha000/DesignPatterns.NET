using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed
{
    interface IStratergy
    {
        bool isMatch(Order order);
        decimal Calculate(Order order);
    }
}
