using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Open_Closed.With
{
    class WithCalculator : IWithCalculator
    {
        private readonly IEnumerable<IStratergy> _rules;

        public WithCalculator(IEnumerable<IStratergy> rules)
        {
            _rules = rules;
        }
        public decimal Calculate(Order order)
        {
            return _rules.First(rule => rule.isMatch(order)).Calculate(order);
        }
    }
}
