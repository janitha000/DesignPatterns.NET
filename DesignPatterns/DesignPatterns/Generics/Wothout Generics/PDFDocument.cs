using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics
{
    class PDFDocument
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public PDFDocument(string name, string content)
        {
            this.Name = name;
            this.Content = content;
        }
    }
}
