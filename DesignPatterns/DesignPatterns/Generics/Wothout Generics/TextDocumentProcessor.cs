using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics
{
    class TextDocumentProcessor : ITextDocumentProcessor 
    {
        private ITextDocumentTranslator translator;

        public TextDocumentProcessor(ITextDocumentTranslator translators)
        {
            this.translator = translators;
        }
        public void Process(TextDocument document)
        {
            TextDocument translated = translator.Translate(document, "En");
        }
    }
}
