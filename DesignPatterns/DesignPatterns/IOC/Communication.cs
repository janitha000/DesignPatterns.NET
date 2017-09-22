using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IOC
{
    class Communication
    {
        //Without IOC
        /*private ApplePhone _phone;

        public Communication()
        {
            _phone = new ApplePhone();
        }*/

        private IPhone _phone;

        public Communication(IPhone phone)
        {
            this._phone = phone;
        }

        public void Speak()
        {
            this._phone.Speak();
        }
    }
}
