using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design
{
    public interface ICustomer
    {
        /// <summary>
        /// This interface has been implemented by customer class
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message);
        public void RecievedMessageFromMediator(string message);
    }
}
