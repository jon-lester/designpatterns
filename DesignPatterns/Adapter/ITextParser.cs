using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// Represents an object which can parse text and return some data.
    /// This is the interface with which parsers must comply to be useful
    /// to our Client class.
    /// </summary>
    interface ITextParser
    {
        IStructuredData Parse(string text);
    }
}
