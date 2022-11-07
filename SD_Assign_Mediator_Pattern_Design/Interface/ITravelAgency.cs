using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ITravelAgency
    {
        void FindCheapestTickets(string departure, string arrival);
        void FindShortestRute(string departure, string arrival);
        void FindCheapestAndFastestFlight(string departure, string arrival);
        void FindAirLines();
        void FindTopRatetAirLines();
        void FindDiscountOnFlights(string departure, string arrival, int Date);
        void FindDayFlights(string departure, string arrival);
        void FindNightFlights(string departure, string arrival);
        void HandlerInqueryFromCustomer();
        void HandlePaymentFromCustomer();
    }
}