using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class StrategyB : Strategy
    {
        public override void Arithmetic()
        {
            Console.WriteLine("{0} is working now", this.GetType().Name);
        }
    }
}
