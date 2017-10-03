using DesignPatterns.Open_Closed.With;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed
{
    class OpenClosedMain
    {
        static void Main(string[] args)
        {
            Order order1 = new Order { Type = "add", ValueOne = 12, ValueTwo = 90 };
            Order order2 = new Order { Type = "sub", ValueOne = 100, ValueTwo = 9 };

            Calculator cal = new Calculator();
            cal.Calculate(order1);

            List<IStratergy> rules = new List<IStratergy>();
            rules.Add(new AddStratergy());
            rules.Add(new SubStratergy());

            WithCalculator calculator = new WithCalculator(rules);
            calculator.Calculate(order1);



        }
    }
}
