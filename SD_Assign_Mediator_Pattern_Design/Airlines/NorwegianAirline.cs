using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class NorwegianAirline : AbstractAirLine
    {

        public string[] Departures = { "Copenhagen", "London", "Paris", "Crotia", "India" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA", "Frankfurt", "Billund" };
        public string NameOfAirline = "Nowegian Airline";
        public double Rate = 4.4;

        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
               this.Price = passengers * 200;
                return Price;
            }

            return 0;
        }

        public int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Duration = 2;
                return Duration;
            }

            return 0;
        }

        public int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            { 
               this.stops = 2;
                return stops;
            }

            return 0;
        }



        public override void CancelFlight()
        {
            Console.WriteLine("Norwegian Airline has cancelled the flight");
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
