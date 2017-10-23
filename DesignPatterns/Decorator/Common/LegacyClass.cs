using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Common
{
    /// <summary>
    /// This is the class for which we want to extend the functionality.
    /// </summary>
    class LegacyClass : IDoesSomething
    {
        public virtual void DoSomeThing(string someParameter, int someOtherParameter)
        {
            Console.WriteLine($"I'm doing something with {someParameter} and {someOtherParameter}!");
        }
    }
}
