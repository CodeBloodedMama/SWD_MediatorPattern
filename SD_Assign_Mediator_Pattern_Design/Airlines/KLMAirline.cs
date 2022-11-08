using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class KLMAirline : AbstractAirLine
    {
        public string[] Departures = { "Copenhagen", "London", "Paris", "Crotia", "India", "Malaga" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA", "Frankfurt", "Billund", "Barcelona" };
        public new string NameOfAirline = "KLM Airline";
        //public double Rate = ;

        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                KLMAirline.Price = passengers * 225;
                return Price;
            }

            return 0;
        }

        public int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Duration = 1;
                return Duration;
            }

            return 0;
        }

        public int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.stops = 1;
                return stops;
            }

            return 0;
        }

        public override void CancelFlight()
        {
            Console.WriteLine("KLM Airline has cancelled the flight");
        }


        public override void GetFlightStatus()
        {
            Console.WriteLine("The flight status is: ");
        }
    }
    
}
