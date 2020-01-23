using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class StrategyContext
    {
        private Strategy _strategy;

        public StrategyContext(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void RunArithmetic()
        {
            _strategy.Arithmetic();
        }
    }
}
