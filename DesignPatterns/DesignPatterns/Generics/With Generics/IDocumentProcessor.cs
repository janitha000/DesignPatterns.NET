using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.With_Generics
{
    interface IDocumentProcessor<TDocument>
    {
        void Process(TDocument document);
    }
}
