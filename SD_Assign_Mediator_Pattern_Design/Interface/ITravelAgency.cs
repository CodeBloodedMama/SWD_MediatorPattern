using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ITravelAgency
    {


        void AddAirline(AbstractAirLine airline);
        void RemoveAirline(AbstractAirLine airline);
        void Send(string message, AbstractAirLine airline);

        void FindCheapestTickets(string departure, string arrival, int passengers);
        void FindShortestRute(string departure, string arrival);
        void FindCheapestAndFastestFlight(string departure, string arrival, int passengers);
        void FindAirLines();
        void FindTopRatetAirLines();
        void FindDiscountOnFlights(string Departure, string Arrival, int Passenger);
        void FindRouteStops(string departure, string arrival);
        int CalculateNumberOfPassenger(int passengers);
        void GetDepartureDateTime(string departure,string arrival);
        string BookTicketForCusotmer();
    }
}