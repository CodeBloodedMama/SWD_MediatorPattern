using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ICustomer
    {

        int AddNumberOfPassengers(int passenger);
        void BookTickets();
        void AskTravelAgencyForTopRatedAirLines();
        void AskTravelAgencyForCheapestFlight();
        void AskTravelAgencyForCheapAndFastFlight();
        void AskTravelAgencyForDiscount();
        void AddDepartureArrival(string departure, string Arrival);
        void PayForTickets();


    }
}