using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Interface;

namespace SD_Assign_Mediator_Pattern_Design
{
    public class Customer:ICustomer
    {
        private ITravelAgency travelAgency;
      
        public Customer(ITravelAgency travelAgency_)
        {
            travelAgency = travelAgency_;

        }

        public void FindAllAirlines()
        {
            travelAgency.FindAirLines();
        }

        public void AskTravelAgencyForTopRatedAirLines()
        {
            travelAgency.FindTopRatetAirLines();
        }


        public void AddNumberOfPassengers(int NumberOfPassengers)
        {
            travelAgency.CalculateNumberOfPassenger(NumberOfPassengers);
        }



        public void AskTravelAgencyForCheapestFlight(string Departure, string Arrival, int Passenger)
        {
           
            travelAgency.FindCheapestTickets(Departure,Arrival,Passenger);
        }

        public void AskTravelAgencyForCheapAndFastFlight(string Departure, string Arrival, int Passenger)
        {
            travelAgency.FindCheapestAndFastestFlight(Departure, Arrival, Passenger);
        }


        public void AskTravelAgencyForDiscount(string Departure, string Arrival, int Passenger)
        {
            travelAgency.FindDiscountOnFlights( Departure,  Arrival,  Passenger);
        }

        public void AskForDepartureTime(string Departure, string Arrival)
        {
            travelAgency.GetDepartureDateTime(Departure, Arrival);
        }

        public void BookTicket(string Departure, string Arrival, int Passenger)
        {
            throw new NotImplementedException();
        }

        public void AskTravelAgencyForFastestRoute(string Departure, string Arrival)
        {
            travelAgency.FindShortestRute(Departure, Arrival);
        }

        public void AskTravelAgencyForStopsBetweenDepartureAndArrival(string Departure, string Arrival)
        {
            travelAgency.FindRouteStops(Departure,Arrival);
        }

    }
}