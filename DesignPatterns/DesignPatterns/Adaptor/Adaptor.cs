using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adaptor
{
    class Adaptor : Animal
    {
        private Human _human = new Human();

        public override void Talk()
        {
            _human.Speak();
        }
    }
}
