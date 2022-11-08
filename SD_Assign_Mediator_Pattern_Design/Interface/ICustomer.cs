using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ICustomer
    {

        void AddNumberOfPassengers(int passenger);
        void AskTravelAgencyForTopRatedAirLines();
        void AskTravelAgencyForCheapestFlight(string Departure, string Arrival, int Passenger);
        void AskTravelAgencyForCheapAndFastFlight(string Departure, string Arrival, int Passenger);
        void AskTravelAgencyForDiscount(string Departure, string Arrival, int Passenger);


    }
}