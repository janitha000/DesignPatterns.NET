using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.With_Generics
{
    class TextDocumentTranslator : IDocumentTranslator<TextDocument>
    {
        public TextDocument Translate(TextDocument document, string language)
        {
            Console.WriteLine("TextDocument translated using generics");
            return document;
        }
    }
}
