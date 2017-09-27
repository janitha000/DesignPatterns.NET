using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.With_Generics
{
    interface IDocumentTranslator<TDocument>
    {
        TDocument Translate(TDocument document, string language);
    }
}
