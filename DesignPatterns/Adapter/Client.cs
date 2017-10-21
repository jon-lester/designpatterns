using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// The client class takes some raw text data and parses
    /// it into a structured object. It knows the source of the
    /// text but wishes to delegate the parsing.
    /// It will therefore use a factory to acquire a parser
    /// suitable for the purpose.
    /// </summary>
    class Client
    {
        // ( the factory would be an injected dependency in production code )
        private ParserFactory _factory = null;

        public IStructuredData ProcessText(string source, string text)
        {
            var parser = _factory.GetParser(source);
            return parser.Parse(text);
        }
    }
}
