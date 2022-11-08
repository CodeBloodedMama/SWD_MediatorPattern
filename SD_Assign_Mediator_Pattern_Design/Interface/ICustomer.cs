using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ICustomer
    {

        void AddNumberOfPassengers(int passenger);
        void FindAllAirlines();
        void AskTravelAgencyForTopRatedAirLines();
        void AskTravelAgencyForCheapestFlight(string Departure, string Arrival, int Passenger);
        void AskTravelAgencyForCheapAndFastFlight(string Departure, string Arrival, int Passenger);
        void AskTravelAgencyForDiscount(string Departure, string Arrival, int Passenger);
        void AskTravelAgencyForFastestRoute(string Departure, string Arrival);
        void AskForDepartureTime(string Departure, string Arrival);
        void AskTravelAgencyForStopsBetweenDepartureAndArrival(string Departure, string Arrival);
        void BookTicket(string Departure, string Arrival, int Passenger);

        void AskTravelAgencyForFastestRoute(string Departure, string Arrival);
        void AskTravelAgencyForStopsBetweenDepartureAndArrival(string v1, string v2);
    }
}