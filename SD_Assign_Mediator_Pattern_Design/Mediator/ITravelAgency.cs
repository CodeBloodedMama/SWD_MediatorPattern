using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ITravelAgency
    {
        string FindCheapestTickets(string departure, string arrival, int passengers);
        string FindShortestRute(string departure, string arrival);
        string FindCheapestAndFastestFlight(string departure, string arrival, int passengers);
        string FindAirLines();
        string FindTopRatetAirLines();
        string FindDiscountOnFlights(string Departure, string Arrival, int Passenger);
        string FindRouteStops(string departure, string arrival);
        int CalculateNumberOfPassenger(int passengers);
        string GetDepartureDateTime(string departure,string arrival);
        void Send(string message, string? departure, string? arrival, int passenger, Customer customer_);
    }
}