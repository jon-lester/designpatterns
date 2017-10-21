using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// This is a class which does not comply with
    /// ITextParser, which we need to do so to use
    /// with the Client class, but which for whatever
    /// reason we're not in a position to change.
    /// </summary>
    class OldTextFormatParser
    {
        private readonly string _rawText;

        public OldTextFormatParser(string someText)
        {
            _rawText = someText;
        }

        /// <summary>
        /// Call ParseText to populate this property with
        /// the structured data.
        /// </summary>
        public object ParsedObject { get; private set; }

        public void ParseText()
        {
            ParsedObject = Parse(_rawText);
        }

        private object Parse (string text)
        {
            var structuredData = new object();
            // .. do some parsing
            return structuredData;
        }
    }
}
