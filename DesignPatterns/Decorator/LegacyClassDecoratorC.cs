using DesignPatterns.Decorator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Decorate the legacy class to add functionality C.
    /// </summary>
    class LegacyClassDecoratorC : IDoesSomething
    {
        private readonly IDoesSomething _decoratee;
        private readonly int _potatos;

        // functionality C needs an extra parameter
        public LegacyClassDecoratorC(IDoesSomething decoratee, int potatos)
        {
            _decoratee = decoratee;
            _potatos = potatos;
        }

        public void DoSomeThing(string someParameter, int someOtherParameter)
        {
            _decoratee.DoSomeThing(someParameter, someOtherParameter);
            Console.WriteLine($"I'm doing something new with {someParameter} and {someOtherParameter} and {_potatos} potatos (C)!");
        }
    }
}
