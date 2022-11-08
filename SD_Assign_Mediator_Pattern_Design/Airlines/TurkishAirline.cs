using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class TurkishAirLine : AbstractAirLine 
    {
        public string[] Departures = { "Copenhagen", "London", "Paris" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA" };
        public string NameOfAirline = "Turkish Airline";
        public double Rate = 3.4;

        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Price = passengers * 100;
                return Price;
            }

            return 0;
        }

        public int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Duration = 3;
                return Duration;
            }

            return 0;
        }

        public int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                return this.stops = 3;
            }

            return 0;
        }



        public override void CancelFlight()
        {
            Console.WriteLine("Turkish Airline has cancelled the flight");
        }

        public override void ChangeFlight()
        {
            Console.WriteLine("The flight has been changed");
        }

        public override void GetFlightStatus()
        {
            Console.WriteLine("The flight status is: ");
        }
    }
}