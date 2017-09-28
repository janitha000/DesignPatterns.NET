using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.More_Generic
{
    class GenericDocumentTranslator<TDocument> : IGenericDocumentTranslator<TDocument>
    {
        private IContentExtractor<TDocument> extractor;

        public GenericDocumentTranslator(IContentExtractor<TDocument> contentExtractor)
        {
            extractor = contentExtractor;
        }

        public TDocument Translate(TDocument document, string language)
        {
            Console.WriteLine("Get path from the physical location");
            string content = extractor.Extract(document);

            return document;
        }
    }
}
