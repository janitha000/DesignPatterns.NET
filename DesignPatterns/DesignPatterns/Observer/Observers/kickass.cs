using DesignPatterns.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Observers
{
    class kickass : Observer
    {
        private MovieStore _movieStore;

        public kickass(MovieStore movieStore)
        {
            this._movieStore = movieStore;
        }

        public override void Update()
        {
            Console.WriteLine($"Kickass notified that latest movie is {_movieStore.latest} ");
        }
    }
}
