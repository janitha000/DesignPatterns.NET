using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pluggable
{
    class PluggableMain
    {
        static void Main(string[] args)
        {
            GetTotal();
            GetEvenTotal();
            GetOddTotal();

            GetTotal(i => true);
            GetTotal(i => i % 2 == 0);
            GetTotal(i => i % 2 == 1);

        }

        public static void GetTotal()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += i;
            }
            Console.WriteLine("total" + total);
        }

        public static void GetEvenTotal()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    total += i;
            }
            Console.WriteLine("total" + total);
        }

        public static void GetOddTotal()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    total += i;
            }
            Console.WriteLine("total" + total);
        }

        public static void GetTotal(Predicate<int> selector)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (selector(i))
                    total += 1;
            }
            Console.WriteLine("Total " + total);
        }
    }
}
