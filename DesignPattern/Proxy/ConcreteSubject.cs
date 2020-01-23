using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class ConcreteSubject: Subject
    {
        public override void request()
        {
            Console.WriteLine("Concrete subject request");
        }
    }
}
