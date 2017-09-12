using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("CAR");
        }
        public override void BuildChassie()
        {
            vehicle["chassie"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "1500cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildWindows()
        {
            vehicle["windows"] = "6";
        }
    }
}
