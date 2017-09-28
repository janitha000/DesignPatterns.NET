using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.More_Generic
{
    interface IContentExtractor<TDocument>
    {
        string Extract(TDocument document);
    }
}
