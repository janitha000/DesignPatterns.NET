using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.SRP.WithSRP
{
    class LCDFactory : SRPFactory
    {
        private IAssembleService _assembler;
        private IDeliverService _deliver;

        public LCDFactory(Phone phone, IAssembleService assembler, IDeliverService deliver) : base(phone)
        {
            _assembler = assembler;
            _deliver = deliver;
        }

        public override void GetPhone()
        {
            _assembler.Assemble(phone);
            _deliver.Deliver(new List<Phone>() { phone });
        }
    }
}
