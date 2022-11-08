using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Airlines;
using SD_Assign_Mediator_Pattern_Design.Interface;


namespace SD_Assign_Mediator_Pattern_Design.Mediator
{
    public class TravelAgency:ITravelAgency
    {
        private TurkishAirLine turkishAirLine = new();
        private NorwegianAirline norwegianAirline = new ();
        private double TurkishAirlinePrice = 0.0;
        private double NorwegianAirlinePrice = 0.0;
        private int TurkishAirlineStops = 0;
        private int NorwegianAirlineStops = 0;
        private int TotalPassenger = 0;
        private int TurkishAirlineDuration = 0;
        private int NorwegianAirlineDuration = 0;
        private string Departure;
        private string Arrival;
        private int NumberOfPassenger;
        private int NumberOfPassengers;


        public void FindCheapestTickets(string departure, string arrival, int passengers)
        {
            TurkishAirlinePrice = turkishAirLine.CalculatePriceOfRoute(departure, arrival,passengers);
            NorwegianAirlinePrice = norwegianAirline.CalculatePriceOfRoute(departure, arrival, passengers);

            if(TurkishAirlinePrice < NorwegianAirlinePrice)
                Console.WriteLine(turkishAirLine.NameOfAirline + " has the cheapest price : " + TurkishAirlinePrice);
            else
                Console.WriteLine(norwegianAirline.NameOfAirline +" has the cheapest price : " + NorwegianAirlinePrice);
        }

        public void FindRouteStops(string departure, string arrival)
        {
            TurkishAirlineStops = turkishAirLine.CalculateStopsOfRoute(departure, arrival);
            NorwegianAirlineStops = norwegianAirline.CalculateStopsOfRoute(departure, arrival);
            
            if (TurkishAirlineStops < NorwegianAirlineStops)
                Console.WriteLine(turkishAirLine.NameOfAirline+" has " + TurkishAirlineStops + " stops to destination");
            else
                Console.WriteLine(norwegianAirline.NameOfAirline + " has  " + NorwegianAirlineStops + " stops to destination");

        }

        public void FindShortestRute(string departure, string arrival)
        {
            TurkishAirlineDuration = turkishAirLine.CalculateDurationOfRoute(departure, arrival);
            NorwegianAirlineDuration = norwegianAirline.CalculateDurationOfRoute(departure, arrival);

            if (TurkishAirlineDuration < NorwegianAirlineDuration)
                Console.WriteLine(turkishAirLine.NameOfAirline + " has the shortest trip with duration of " + TurkishAirlineDuration + " stops");
            else
                Console.WriteLine(norwegianAirline.NameOfAirline + " has the shortest trip with duration of " + NorwegianAirlineDuration + " stops");

        }

        public void FindCheapestAndFastestFlight(string departure, string arrival, int passengers)
        {
            FindCheapestTickets(departure,arrival,passengers);
            FindShortestRute(departure, arrival);
        }

        public void FindAirLines()
        {
            Console.WriteLine();
            Console.WriteLine("List of all Airlines");
            Console.WriteLine(turkishAirLine.NameOfAirline);
            Console.WriteLine(norwegianAirline.NameOfAirline);
        }

        public void FindTopRatetAirLines()
        {
            if (turkishAirLine.Rate > norwegianAirline.Rate)
                Console.WriteLine(turkishAirLine.NameOfAirline + " by having rate of " + turkishAirLine.Rate +
                                  " is toprated Airline");
        }
        
      
        public int CalculateNumberOfPassenger(int NumberOfPassengers)
        {
            if (NumberOfPassengers < 0 & NumberOfPassengers > 5)
                Console.WriteLine("Please add number of passenger between 0-5");
            TotalPassenger = NumberOfPassengers;
            return TotalPassenger;
        }

        public void DisplayInterfaceToCustomer()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Welcome to Our Travel Agency");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Press A to see the list of all airlines \n" +
                              "Press B to book ticket\n" +
                              "Press D to get discount, if available");
        }

        public void HandleBooking()
        {
            FindCheapestAndFastestFlight(Departure, Arrival, NumberOfPassengers);
        }
     
        public void FindDiscountOnFlights(string Departure, string Arrival, int Passenger)
        {
            double TurkDisc = turkishAirLine.MakeDiscount(Departure,Arrival, NumberOfPassengers);
            double NorDisc = norwegianAirline.MakeDiscount(Departure, Arrival, NumberOfPassengers);

            Console.WriteLine("AirLines with their Discounts");
            Console.WriteLine("Turkish Airline has " + TurkDisc + " % discount");
            Console.WriteLine("Norwegian Airline has " + NorDisc + " % discount");

        }

   
        public void HandlerInqueryFromCustomer()
        {
            throw new NotImplementedException();
        }

        public void HandlePaymentFromCustomer()
        {
            throw new NotImplementedException();
        }
    }
}