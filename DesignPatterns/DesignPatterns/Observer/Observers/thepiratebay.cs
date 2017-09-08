using DesignPatterns.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Observers
{
    class thepiratebay : Observer
    {
        private MovieStore _movieStore;

        public thepiratebay(MovieStore movieStore)
        {
            this._movieStore = movieStore;
        }
        public override void Update()
        {
            Console.WriteLine($"thepiratebay is notified the latest {_movieStore.latest}");
        }
    }
}
