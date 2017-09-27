using DesignPatterns.Generics.With_Generics;
using DesignPatterns.Generics.Wothout_Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics
{
    class GenericsMain
    {
        static void Main(string[] args)
        {
            TextDocument document = new TextDocument("Test", "blaaaaaaa");

            //withour generics
            ITextDocumentTranslator translator = new TextDocumentTranslatorwithoutGenerics();
            TextDocumentProcessor processor = new TextDocumentProcessor(translator);
            processor.Process(document);

            //With generics
            var processor2 = new DocumentProcessor<TextDocument>(
                new TextDocumentTranslator());
            processor2.Process(document);

        }
    }
}
