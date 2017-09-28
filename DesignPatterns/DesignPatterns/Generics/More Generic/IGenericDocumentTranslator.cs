using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.More_Generic
{
    interface IGenericDocumentTranslator<TDocument>
    {
        TDocument Translate(TDocument document, string language); 
    }
}
