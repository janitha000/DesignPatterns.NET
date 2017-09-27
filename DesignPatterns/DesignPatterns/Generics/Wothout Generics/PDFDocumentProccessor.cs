using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics
{
    class PDFDocumentProccessor : IPDFProcessor 
    {
        private IPDFDocumentTranslator translator;

        public void Process(PDFDocument document)
        {
            PDFDocument translated = translator.Translate(document, "EN");
        }
    }
}
