using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC.DI.ServiceLocator
{
    class Communication
    {
        private IPhone _phone;
        PhoneLocator locator = new PhoneLocator();

        public Communication(int index)
        {
            this._phone = locator.LocatePhone(index);
        }

        //Communication comm = new Communication(1);
    }
}
