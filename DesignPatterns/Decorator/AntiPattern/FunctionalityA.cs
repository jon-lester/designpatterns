using DesignPatterns.Decorator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.AntiPattern
{
    class FunctionalityA : LegacyClass, IDoesSomething
    {
        public override void DoSomeThing(string someParameter, int someOtherParameter)
        {
            base.DoSomeThing(someParameter, someOtherParameter);
            Console.WriteLine($"I'm doing something new with {someParameter} and {someOtherParameter} (A)!");
        }
    }
}
