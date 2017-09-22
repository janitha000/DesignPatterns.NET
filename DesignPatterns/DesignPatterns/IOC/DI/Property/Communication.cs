using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC.DI.Property
{
    class Communication
    {
        private IPhone _phone;

        public IPhone phone
        {
            set
            {
                _phone = value;
            }
        }

        //Communication comm = new Communication();
        //coom.phone = new ApplePhone();
    }
}
