using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Interface;

namespace SD_Assign_Mediator_Pattern_Design
{
    public class Customer:ICustomer
    {
        string Departure = "Copenhagen";
        string Arrival = "Germany";
        int Passengers = 3;
        private ITravelAgency travelAgency;

        public Customer(ITravelAgency travelAgency_)
        {
            travelAgency = travelAgency_;

        }
        /// <summary>
        /// Customer send message to Mediator(Travel agency)
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            travelAgency.Send(message,Departure,Arrival,Passengers, this);
        }

        /// <summary>
        /// Customer receives message from mediator
        /// </summary>
        /// <param name="message"></param>
        public void RecievedMessageFromMediator(string message)
        {
            Console.WriteLine("Customer received message from Mediator : \n" + message);
        }

    }
}