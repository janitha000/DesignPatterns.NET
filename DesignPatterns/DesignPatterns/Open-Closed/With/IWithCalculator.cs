using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed.With
{
    interface IWithCalculator
    {
        decimal Calculate(Order order);
    }
}
