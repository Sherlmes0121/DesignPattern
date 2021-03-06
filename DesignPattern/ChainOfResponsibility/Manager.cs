﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class Manager: Supervisor
    {
        public override void HandleRequest(int absenceDays)
        {
            if (5 < absenceDays && absenceDays <= 10)
            {
                Console.WriteLine("{0} has approved the absence request - absence days is {1}", this.GetType().Name, absenceDays);
            }
            else if (supervisor != null)
            {
                supervisor.HandleRequest(absenceDays);
            }
        }
    }
}
