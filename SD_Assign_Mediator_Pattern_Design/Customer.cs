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
        string FirstName { get; set; } = null!; 
        string LastName { get; set; }
        int PhoneNumber { get; set; }
        string Email { get; set; }
        string Gender { get; set; }
        public int TotalPassenger = 0;

        public void AskTravelAgencyForTopRatedAirLines()
        {
            throw new NotImplementedException();
        }


        public void AddNumberOfPassengers(int NumberOfPassengers)
        {
            if(NumberOfPassengers < 0 & NumberOfPassengers> 5)
                Console.WriteLine("Please add number of passenger between 0-5");
            TotalPassenger = NumberOfPassengers;
        }

        public void BookTickets()
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