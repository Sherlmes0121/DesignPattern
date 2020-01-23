using DesignPattern.ChainOfResponsibility;
using DesignPattern.Decorator;
using DesignPattern.Strategy;
using DesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chain Of Responsibility
            Teamleader teamleader = new Teamleader();
            Manager manager = new Manager();
            SrManager srManager = new SrManager();

            teamleader.SetSupervisor(manager);
            manager.SetSupervisor(srManager);

            var absenceRequests = new int[] { 5, 10, 15, 20 };

            foreach (var absenceRequest in absenceRequests)
            {
                teamleader.HandleRequest(absenceRequest);
            }

            Console.Read();
            #endregion

            #region Strategy
            StrategyContext strategyContextA = new StrategyContext(new StrategyA());
            strategyContextA.RunArithmetic();

            StrategyContext strategyContextB = new StrategyContext(new StrategyB());
            strategyContextB.RunArithmetic();

            Console.Read();
            #endregion

            #region Decorator
            ConcreteComponent concreteComponent = new ConcreteComponent();
            ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.SetComponent(concreteComponent);
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorB.Operation();

            Console.Read();
            #endregion

            #region Proxy
            Proxy.Proxy proxy = new Proxy.Proxy();
            proxy.request();

            Console.Read();
            #endregion
        }
    }
}
