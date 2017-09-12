using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    class MotorCycleBuilder : VehicleBuilder
    {

        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildChassie()
        {
            vehicle["chassie"] = "Cycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "100cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildWindows()
        {
            vehicle["windows"] = "0";
        }
    }
}
