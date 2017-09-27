using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Generics
{
    class TextDocument
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public TextDocument(string name, string content)
        {
            this.Name = name;
            this.Content = content;
        }
    }
}
