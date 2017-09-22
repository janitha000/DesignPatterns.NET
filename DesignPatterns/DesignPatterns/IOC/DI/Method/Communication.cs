using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC.DI.Method
{
    class Communication
    {
        private IPhone _phone;

        public void GetPhone(IPhone phone)
        {
            this._phone = phone;
        }

        //Communication comm = new Communication();
        //comm.GetPhone(new ApplePhone());
    }
}
