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
        private TurkishAirLine turkishAirLine = new TurkishAirLine();
        private NorwegianAirline norwegianAirline = new NorwegianAirline();
        private int TurkishAirlinePrice = 0;
        private int NorwegianAirlinePrice = 0;
        private int TurkishAirlineStops = 0;
        private int NorwegianAirlineStops = 0;
        private int TotalPassenger = 0;
        private int TurkishAirlineDuration = 0;
        private int NorwegianAirlineDuration = 0;


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
            TurkishAirlineStops = turkishAirLine.CalculateDurationOfRoute(departure, arrival);
            NorwegianAirlineStops = norwegianAirline.CalculateDurationOfRoute(departure, arrival);
            
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

     
        public void FindDiscountOnFlights(string departure, string arrival, int Date)
        {
            throw new NotImplementedException();
        }

        public void FindDayFlights(string departure, string arrival)
        {
            throw new NotImplementedException();
        }

        public void FindNightFlights(string departure, string arrival)
        {
            throw new NotImplementedException();
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