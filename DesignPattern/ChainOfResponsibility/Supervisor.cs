using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public abstract class Supervisor
    {
        protected Supervisor supervisor;

        public void SetSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

        public abstract void HandleRequest(int absenceDays);
    }
}
