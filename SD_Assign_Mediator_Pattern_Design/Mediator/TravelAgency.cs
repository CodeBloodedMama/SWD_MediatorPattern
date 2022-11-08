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
        private string Departure = null;
        private string Arrival = null;
        private int NumberOfPassengers;

        public List<AbstractAirLine> AirlineList = new List<AbstractAirLine>();


        public void AddAirline(AbstractAirLine airline)
        {
            AirlineList.Add(airline);
        }

        public void RemoveAirline(AbstractAirLine airline)
        {
            AirlineList.Remove(airline);
        }

        public void Send(string message, AbstractAirLine airline)
        {
            foreach (var item in AirlineList)
            {
                if (item != airline)
                {
                    item.Notify(message);
                }
            }
        }

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
            
                Console.WriteLine(turkishAirLine.NameOfAirline+" has " + TurkishAirlineStops + " stops to destination");
                Console.WriteLine(norwegianAirline.NameOfAirline + " has  " + NorwegianAirlineStops + " stops to destination");

        }

        public void FindShortestRute(string departure, string arrival)
        {
            TurkishAirlineDuration = turkishAirLine.CalculateDurationOfRoute(departure, arrival);
            NorwegianAirlineDuration = norwegianAirline.CalculateDurationOfRoute(departure, arrival);

            if (TurkishAirlineDuration < NorwegianAirlineDuration)
                Console.WriteLine(turkishAirLine.NameOfAirline + " has the shortest trip with " + TurkishAirlineDuration + " stops");
            else
                Console.WriteLine(norwegianAirline.NameOfAirline + " has the shortest trip with " + NorwegianAirlineDuration + " stops");

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
            else
            {
                Console.WriteLine(norwegianAirline.NameOfAirline + " by having rate of " + norwegianAirline.Rate +
                                  " is toprated Airline");
            }
        }
        
      
        public int CalculateNumberOfPassenger(int NumberOfPassengers)
        {
            if (NumberOfPassengers < 0 & NumberOfPassengers > 5)
                Console.WriteLine("Please add number of passenger between 0-5");
            TotalPassenger = NumberOfPassengers;
            return TotalPassenger;
        }

      
        public void GetDepartureDateTime(string departure,string arrival)
        {
          string TurkishAirlineDepatureDate =  "Departure date for turkish airline " + Convert.ToString(turkishAirLine.GetDepartureDate(departure, arrival));
          string NorwegianAirlineDepartureDate =
              "\nDeparture date for Norwegian airline " + Convert.ToString(norwegianAirline.GetDepartureDate(departure,arrival));

          Console.WriteLine(TurkishAirlineDepatureDate + NorwegianAirlineDepartureDate);
        }

        public string BookTicketForCusotmer()
        {
            throw new NotImplementedException();
        }

     
        public void FindDiscountOnFlights(string Departure, string Arrival, int Passenger)
        {
            double TurkDisc = turkishAirLine.MakeDiscount(Departure,Arrival, Passenger);
            double NorDisc = norwegianAirline.MakeDiscount(Departure, Arrival, Passenger);

            Console.WriteLine("AirLines with their Discounts");
            Console.WriteLine("Turkish Airline has " + TurkDisc + " % discount");
            Console.WriteLine("Norwegian Airline has " + NorDisc + " % discount");

        }

        

    }
}