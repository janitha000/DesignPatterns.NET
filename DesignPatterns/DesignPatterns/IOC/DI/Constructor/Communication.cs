using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC.DI.Constructor
{
    class Communication
    {
        private IPhone _phone;

        public Communication(IPhone phone)
        {
            this._phone = phone;
        }

        //Communication comm = new Communication(new ApplePhone());
    }
}
