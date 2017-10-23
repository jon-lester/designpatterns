using DesignPatterns.Decorator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Decorate the legacy class to add functionality A.
    /// </summary>
    class LegacyClassDecoratorA : IDoesSomething
    {
        private readonly IDoesSomething _decoratee;

        public LegacyClassDecoratorA(IDoesSomething decoratee)
        {
            _decoratee = decoratee;
        }

        public void DoSomeThing(string someParameter, int someOtherParameter)
        {
            _decoratee.DoSomeThing(someParameter, someOtherParameter);
            Console.WriteLine($"I'm doing something new with {someParameter} and {someOtherParameter} (A)!");
        }
    }
}
