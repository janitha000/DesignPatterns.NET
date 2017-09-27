using DesignPatterns.Generics.With_Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.With_Generics
{
    class DocumentProcessor<TDocument> : IDocumentProcessor<TDocument>
    {
        private IDocumentTranslator<TDocument> translator;

        public DocumentProcessor(IDocumentTranslator<TDocument> translator)
        {
            this.translator = translator;
        }

        public void Process(TDocument document)
        {
            TDocument translated = translator.Translate(document, "EN");
        }
    }
}
