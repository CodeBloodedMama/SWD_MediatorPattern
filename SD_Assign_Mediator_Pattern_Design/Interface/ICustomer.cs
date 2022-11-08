using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Interface
{
    public interface ICustomer
    {
        AbstractAirLine AbstractAirLine { get; set; }

        void AddNumberOfPassengers(int passenger);
        void BookTickets();
        void AskTravelAgencyForTopRatedAirLines();
        void AskTravelAgencyForCheapestFlight();
        void AskTravelAgencyForCheapAndFastFlight();
        void AskTravelAgencyForDiscount();
        void PayForTickets();

    }
}