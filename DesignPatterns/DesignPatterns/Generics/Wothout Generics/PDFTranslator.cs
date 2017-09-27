using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.Wothout_Generics
{
    class PDFTranslator : IPDFDocumentTranslator
    {
        public PDFDocument Translate(PDFDocument document, string language)
        {
            Console.WriteLine("PDFDocument translated");
            return document;
        }
    }
}
