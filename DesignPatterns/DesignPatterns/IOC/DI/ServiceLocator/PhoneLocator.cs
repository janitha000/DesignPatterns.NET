using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC.DI.ServiceLocator
{
    class PhoneLocator
    {
        public IPhone LocatePhone(int index)
        {
            if (index == 1)
                return new ApplePhone();
            if (index == 2)
                return new SamsungPhone();
            else
                return null;
        }
    }
}
