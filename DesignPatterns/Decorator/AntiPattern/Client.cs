using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator.Common;

namespace DesignPatterns.Decorator.AntiPattern
{
    /// <summary>
    /// This client attempts to make use of subclassing to
    /// add functionality to the IDoesSomething interface.
    /// </summary>
    class Client
    {
        public void Execute()
        {
            // using the original superclass, the client can access the old functionality
            IDoesSomething oldFunctionality = new LegacyClass();
            oldFunctionality.DoSomeThing("foo", 5);

            // new functionality A can be accessed via the FunctionalityA class,
            // which additionally provides the old functionality
            IDoesSomething functionalityA = new FunctionalityA();
            oldFunctionality.DoSomeThing("foo", 5);

            // new functionality B can be accessed via the FunctionalityB class,
            // which also provides the old functionality
            IDoesSomething functionalityB = new FunctionalityB();
            oldFunctionality.DoSomeThing("foo", 5);

            // what happens when we want both A and B?
            // IDoesSomething functionalityAandB = new FunctionalityAAndB(); ?

            // what when we want A and C but not B?

            // when functionalities C-Z or more are added, we need either an unwieldy
            // subclass hierarchy or some convoluted logic.
        }
    }
}
