using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class NorwegianAirline : AbstractAirLine
    {
        public string NameOfAirline = "Norwegian Airlines";
        public string[] Departures = { "Copenhagen", "London", "Paris", "Crotia", "India" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA", "Frankfurt", "Billund", "Germany" };
        public DateTime CPHGER = new DateTime(2023, 12, 25);
        public DateTime LONHAM = new DateTime(2022, 11, 2);
        public DateTime INDFRANK = new DateTime(2023, 03, 05);
        public double Rate = 4.4;

        public override string FindDeparture(string departure)
        {
            for (int i = 0; i < Departures.Length; i++)
            {
                if (Departures[i] == departure)
                    return Departures[i];
            }
            return "";
        }

        public override string FindArrival(string arrival)
        {
            for (int i = 0; i < Arrivals.Length; i++)
            {
                if (Arrivals[i] == arrival)
                    return Arrivals[i];
            }
            return "";
        }

        public override DateTime GetDepartureDate(string departure, string arrival)
        {
            if (FindDeparture(departure) == "Copenhagen" && FindArrival(arrival) == "Germany")
                return CPHGER;
            if (FindDeparture(departure) == "London" && FindArrival(arrival) == "Hamburg")
                return LONHAM;
            if (FindDeparture(departure) == "India" && FindArrival(arrival) == "Frankfurt")
                return INDFRANK;
            else
            {
                return new DateTime(0000, 00, 00);
            }
        }

        public override double CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Germany")
            {
                Price = passengers * 200;
                return Price;
            }

            return 0;
        }

        public override int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Germany")
            {
                this.Duration = 2;
                return Duration;
            }

            return 0;
        }

        public override int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            { 
               this.stops = 2;
                return stops;
            }

            return 0;
        }

        public override double MakeDiscount(string departure, string arrival, int passenger)
        {
            if (departure == "Copenhagen" && arrival == "Germany" && passenger > 1)
                Price = passenger * 150;
            Discount = ((Price * 2 / 100) + passenger * 1 / 100);
            return Discount;
        }

        public override double CalculatePriceForRoute(string departure, string arrival, int passenger)
        {
            if (departure == "Copenhagen" && arrival == "Germany" && passenger > 1)
                Price = passenger * 200;
            return Price;
        }
    }
}
