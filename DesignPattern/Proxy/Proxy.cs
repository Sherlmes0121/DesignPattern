using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class Proxy: Subject
    {
        ConcreteSubject concreteSubject;

        public override void request()
        {
            if (concreteSubject == null)
            {
               concreteSubject = new ConcreteSubject();
            }

            concreteSubject.request();
        }
    }
}
