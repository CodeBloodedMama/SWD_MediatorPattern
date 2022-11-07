using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Interface;

namespace SD_Assign_Mediator_Pattern_Design
{
    public class Customer:ICustomer
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int PhoneNumber { get; set; }
        string Email { get; set; }
        string Gender { get; set; }
        public void AddNumberOfPassengers(int passenger)
        {
            throw new NotImplementedException();
        }

        public void BookTickets()
        {
            throw new NotImplementedException();
        }

        public void AskTravelAgencyForTopRatedAirLines()
        {
            throw new NotImplementedException();
        }

        public void AskTravelAgencyForCheapestFlight()
        {
            throw new NotImplementedException();
        }

        public void AskTravelAgencyForCheapAndFastFlight()
        {
            throw new NotImplementedException();
        }

        public void AskTravelAgencyForDiscount()
        {
            throw new NotImplementedException();
        }

        public void PayForTickets()
        {
            throw new NotImplementedException();
        }
    }
}