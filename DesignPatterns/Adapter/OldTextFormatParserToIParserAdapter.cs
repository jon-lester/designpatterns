using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// Implements the adapter pattern to make OldTextFormatParser
    /// compatible with the IParser interface. This is an object
    /// adapter which contains an instance of the adapted class,
    /// as opposed to a class adapter which would subclass it
    /// (thus opting for composition over inheritance in this
    /// implementation).
    /// 
    /// Note - the adapter pattern changes the interface of the
    /// adapted code to comply with a new interface.
    /// </summary>
    class OldTextFormatParserToIParserAdapter : ITextParser
    {
        public IStructuredData Parse(string text)
        {
            var oldParser = new OldTextFormatParser(text);
            oldParser.ParseText();
            return OldParsedObjectToIStructuredData(oldParser.ParsedObject);
        }

        // to keep things simple, in this example the adapter is also responsible
        // for converting the old format of structured data to the required
        // interface, however the conversion could potentially have its own class
        // per the single responsibility principal - this adapter's responsibility
        // being to make the old parser comply with IParser, and the other's being
        // to make 'object data' comply with IStructuredData.
        private IStructuredData OldParsedObjectToIStructuredData(object data)
        {
            // do data conversion
            return data as IStructuredData;
        }
    }
}
