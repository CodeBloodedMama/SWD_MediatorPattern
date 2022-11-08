using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Interface;

namespace SD_Assign_Mediator_Pattern_Design
{
    public class Customer : ICustomer
    {
        private ITravelAgency travelAgency;

        public Customer(ITravelAgency travelAgency_)
        {
            travelAgency = travelAgency_;

        }

        public void Send(string message)
        {
            travelAgency.Send(message,this);
        }

        public void RecievedMessageFromMediator(string message)
        {
            Console.WriteLine("Message recieved from Mediator : \n" + message);
        }
        
    }
}