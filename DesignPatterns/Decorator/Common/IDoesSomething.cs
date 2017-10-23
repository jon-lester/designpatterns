using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Common
{
    /// <summary>
    /// Our legacy class (and its extensions) implement this interface.
    /// </summary>
    interface IDoesSomething
    {
        void DoSomeThing(string someParameter, int someOtherParameter);
    }
}
