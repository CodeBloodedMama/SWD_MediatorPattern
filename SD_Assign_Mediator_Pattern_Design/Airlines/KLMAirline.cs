//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class KLMAirline : AbstractAirLine
    {
        public string[] Departures = { "Copenhagen", "London", "Paris", "Crotia", "India", "Malaga" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA", "Frankfurt", "Billund", "Barcelona" };
        public new string NameOfAirline = "KLM Airline";

        public override void CancelFlight()
        {
            Console.WriteLine("KLM Airline has cancelled the flight");
        }

    

        public override int CalculateStopsOfRoute(string departure, string arrival)
        {
            throw new NotImplementedException();
        }

        public override double MakeDiscount(string departure, string arrival, int passenger)
        {
            throw new NotImplementedException();
        }

        public override double CalculatePriceForRoute(string departure, string arrival, int passenger)
        {
            throw new NotImplementedException();
        }

        public override string FindDeparture(string departure)
        {
            throw new NotImplementedException();
        }

        public override string FindArrival(string arrival)
        {
            throw new NotImplementedException();
        }

        public override DateTime GetDepartureDate(string departure, string arrival)
        {
            throw new NotImplementedException();
        }

        public override void GetFlightStatus()
        {
            throw new NotImplementedException();
        }

        public override void GetFlightInfo(string departure, string arrival)
        {
            throw new NotImplementedException();
        }

        internal override void Notify(string message)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override double CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            throw new NotImplementedException();
        }

        public override int CalculateDurationOfRoute(string departure, string arrival)
        {
            throw new NotImplementedException();
        }
    }
}
   




