using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Shop
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildChassie();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildWindows();
        }
    }
}
