using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.More_Generic
{
    class TextContentExtractor : IContentExtractor<TextDocument>
    {
        public string Extract(TextDocument document)
        {
            string content = "EXtracting from the text document";
            Console.WriteLine(content);
            return content;
        }
    }
}
