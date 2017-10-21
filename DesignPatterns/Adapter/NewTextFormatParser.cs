using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// This is the concrete implementation of a parser which
    /// complies with ITextParser, and therefore needs no adaptor.
    /// </summary>
    class NewTextFormatParser : ITextParser
    {
        public IStructuredData Parse(string text)
        {
            // ..do some parsing
            return new object() as IStructuredData;
        }
    }
}
