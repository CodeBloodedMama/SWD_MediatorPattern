using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ITravelAgency
    {
        void FindCheapestTickets(string departure, string arrival, int passengers);
        void FindShortestRute(string departure, string arrival);
        void FindCheapestAndFastestFlight(string departure, string arrival, int passengers);
        void FindAirLines();
        void FindTopRatetAirLines();
        void FindDiscountOnFlights(string Departure, string Arrival, int Passenger);
        void FindRouteStops(string departure, string arrival);
        public int CalculateNumberOfPassenger(int passengers);
        void HandlerInqueryFromCustomer();
        void HandlePaymentFromCustomer();
    }
}