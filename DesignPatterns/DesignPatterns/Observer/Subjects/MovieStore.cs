using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Subjects
{
    class MovieStore : Store
    {
        private string _latest;

        public string latest
        {
            get { return _latest; }
            set { _latest = value; }
        }
    }
}
