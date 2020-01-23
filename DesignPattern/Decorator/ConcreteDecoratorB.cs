using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "Decorator B";
            Console.WriteLine(addedState);
        }
    }
}
