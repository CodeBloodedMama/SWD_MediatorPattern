using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ICustomer
    {
        public void Send(string message);
        public void RecievedMessageFromMediator(string message);

    }
}