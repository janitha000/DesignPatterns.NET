using DesignPatterns.Observer.Observers;
using DesignPatterns.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    class ObserverMain
    {
        static void Main(string[] args)
        {
            MovieStore movieStore = new MovieStore();

            movieStore.Attach(new kickass(movieStore));
            movieStore.Attach(new thepiratebay(movieStore));

            movieStore.latest = "WonderWoman";
            movieStore.notify();

        }
    }
}
