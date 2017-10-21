using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class ParserFactory
    {
        public ITextParser GetParser (string source)
        {
            switch (source)
            {
                case "newtextformat":
                    // NewTextFormatParser is compliant with the desired interface
                    return new NewTextFormatParser();
                case "oldtextformat":
                    // OldTextFormatParser is not compliant, so an adapter is needed
                    return new OldTextFormatParserToIParserAdapter();
                default:
                    throw new NotImplementedException("Parser data source not supported.");
            }
        }
    }
}
