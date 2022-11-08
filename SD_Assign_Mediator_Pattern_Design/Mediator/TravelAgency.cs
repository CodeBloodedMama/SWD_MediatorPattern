using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.Airlines;
using SD_Assign_Mediator_Pattern_Design.Interface;


namespace SD_Assign_Mediator_Pattern_Design.Mediator
{
    public class TravelAgency:ITravelAgency
    {
        private TurkishAirLine turkishAirLine = new();
        private NorwegianAirline norwegianAirline = new ();
        private Customer c1;
        private double TurkishAirlinePrice = 0.0;
        private double NorwegianAirlinePrice = 0.0;
        private int TurkishAirlineStops = 0;
        private int NorwegianAirlineStops = 0;
        private int TotalPassenger = 0;
        private int TurkishAirlineDuration = 0;
        private int NorwegianAirlineDuration = 0;
        string Departure = "Copenhagen";
        string Arrival = "Germany";
        int Passengers = 3;
        private string PrintResult = "";

        public Customer Customer;
        public Customer customer1
        {
            set
            {
                Customer = value;
            }
        }


   
        public void Send(string message, Customer customer_)
        {
            string result = "";
           switch (message)
                {
                    case "A":
                    case "a":
                        result = FindAirLines();
                        customer_.RecievedMessageFromMediator(result);
                        break;
                    case "C":
                    case "c":
                      result =  FindCheapestTickets(Departure,Arrival,Passengers);
                      customer_.RecievedMessageFromMediator(result);
                      break;
                    case "S":
                    case "s":;
                        result = FindRouteStops(Departure, Arrival);
                        customer_.RecievedMessageFromMediator(result);
                        break;
                    case "F":
                    case "f":
                        result = FindCheapestAndFastestFlight(Departure, Arrival, Passengers);
                        customer_.RecievedMessageFromMediator(result);
                        break;

                    case "D":
                    case "d":
                        result = FindDiscountOnFlights(Departure, Arrival, Passengers);
                        customer_.RecievedMessageFromMediator(result);
                        break;
                    case "T":
                    case "t":
                        result = FindTopRatetAirLines();
                        customer_.RecievedMessageFromMediator(result);
                        break;
                case "R":
                case "r":
                    result = FindShortestRute(Departure, Arrival);
                    customer_.RecievedMessageFromMediator(result);
                    break;
                case "G":
                case "g":
                    result = GetDepartureDateTime(Departure, Arrival);
                    customer_.RecievedMessageFromMediator(result);
                    break;
                default:
                        break;
                }
        }
        
        public string FindCheapestTickets(string departure, string arrival, int passengers)
        {
            string CheapestPrice = "";
            TurkishAirlinePrice = turkishAirLine.CalculatePriceOfRoute(departure, arrival,passengers);
            NorwegianAirlinePrice = norwegianAirline.CalculatePriceOfRoute(departure, arrival, passengers);

            if(TurkishAirlinePrice < NorwegianAirlinePrice)
                CheapestPrice = turkishAirLine.NameOfAirline + " has the cheapest price : " + TurkishAirlinePrice;
            else
                CheapestPrice = norwegianAirline.NameOfAirline +" has the cheapest price : " + NorwegianAirlinePrice;
            return CheapestPrice;
        }

        public string FindRouteStops(string departure, string arrival)
        {
            TurkishAirlineStops = turkishAirLine.CalculateStopsOfRoute(departure, arrival);
            NorwegianAirlineStops = norwegianAirline.CalculateStopsOfRoute(departure, arrival);
            
                PrintResult = turkishAirLine.NameOfAirline+" has " + TurkishAirlineStops + " stops to destination\n" +
                norwegianAirline.NameOfAirline + " has  " + NorwegianAirlineStops + " stops to destination";
                return PrintResult;

        }

        public string FindShortestRute(string departure, string arrival)
        {
            TurkishAirlineDuration = turkishAirLine.CalculateDurationOfRoute(departure, arrival);
            NorwegianAirlineDuration = norwegianAirline.CalculateDurationOfRoute(departure, arrival);

            if (TurkishAirlineDuration < NorwegianAirlineDuration)
                PrintResult = turkishAirLine.NameOfAirline + " has the shortest trip with " + TurkishAirlineDuration + " stops";
            else
            PrintResult = norwegianAirline.NameOfAirline + " has the shortest trip with " + NorwegianAirlineDuration + " stops";
            return PrintResult;

        }

        public string FindCheapestAndFastestFlight(string departure, string arrival, int passengers)
        {
          PrintResult =  FindCheapestTickets(departure,arrival,passengers) + FindShortestRute(departure, arrival);
          return PrintResult;
        }

        public string FindAirLines()
        {
            return "\nList of all Airlines \n" + turkishAirLine.NameOfAirline + "\n"  +norwegianAirline.NameOfAirline;
        }

        public string FindTopRatetAirLines()
        {
            if (turkishAirLine.Rate > norwegianAirline.Rate)
                PrintResult = turkishAirLine.NameOfAirline + " by having rate of " + turkishAirLine.Rate +
                                  " is toprated Airline";
            else
            {
                PrintResult = norwegianAirline.NameOfAirline + " by having rate of " + norwegianAirline.Rate +
                                  " is toprated Airline";
            }

            return PrintResult;
        }
        
      
        public int CalculateNumberOfPassenger(int NumberOfPassengers)
        {
            if (NumberOfPassengers < 0 & NumberOfPassengers > 5)
                Console.WriteLine("Please add number of passenger between 0-5");
            TotalPassenger = NumberOfPassengers;
            return TotalPassenger;
        }

      
        public string GetDepartureDateTime(string departure,string arrival)
        {
          string TurkishAirlineDepatureDate =  "Departure date for turkish airline " + Convert.ToString(turkishAirLine.GetDepartureDate(departure, arrival));
          string NorwegianAirlineDepartureDate =
              "\nDeparture date for Norwegian airline " + Convert.ToString(norwegianAirline.GetDepartureDate(departure,arrival));

          return TurkishAirlineDepatureDate + NorwegianAirlineDepartureDate;
        }

     public string FindDiscountOnFlights(string Departure, string Arrival, int Passenger)
        {
            double TurkDisc = turkishAirLine.MakeDiscount(Departure,Arrival, Passenger);
            double NorDisc = norwegianAirline.MakeDiscount(Departure, Arrival, Passenger);

            PrintResult = "AirLines with their Discounts\n"+ "Turkish Airline has " + TurkDisc + " % discount"+
            "\nNorwegian Airline has " + NorDisc + " % discount";
            return PrintResult;

        }
    }
}