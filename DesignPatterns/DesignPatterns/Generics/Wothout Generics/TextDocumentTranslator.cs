using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.Wothout_Generics
{
    class TextDocumentTranslatorwithoutGenerics : ITextDocumentTranslator
    {
        public TextDocument Translate(TextDocument document, string Language)
        {
            Console.WriteLine("TextDocument translated");
            return document;
        }
    }
}
