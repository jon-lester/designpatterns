using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// This is a mock API connection that the client class needs to construct.
    /// </summary>
    class ApiConnection
    {
        public string Uri { get; set; }
        public string Method { get; set; }
        public bool UseCors { get; set; }
        public List<string> Headers { get; } = new List<string>();
        public bool UseSSL { get; set; }
    }
}
