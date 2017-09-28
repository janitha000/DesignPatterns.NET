using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics.More_Generic
{
    class PDFContentExtrator : IContentExtractor<PDFDocument>
    {
        public string Extract(PDFDocument document)
        {
            string content = "EXtracting from the PDF document";
            Console.WriteLine(content);
            return content;
        }
    }
}
