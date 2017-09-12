using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Vehicle
    {
        private string _type;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string type)
        {
            this._type = type;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _type);
            Console.WriteLine(" Chassie : {0}", _parts["chassie"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Windows : {0}", _parts["windows"]);
        }
    }
}
