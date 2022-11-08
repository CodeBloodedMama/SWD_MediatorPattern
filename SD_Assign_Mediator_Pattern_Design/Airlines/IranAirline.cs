using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class IranAirline : AbstractAirLine
    {
        public string[] Departures = { "Copenhagen", "London", "Paris", "Croatia" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA", "Frankfurt" };
        public string NameOfAirline = "Iran Airline";
        //public double Rate = ;

        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Price = passengers * 150;
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
                return this.stops = 2;
            }

            return 0;
        }

        public override void CancelFlight()
        {
            Console.WriteLine("Iran Airline has cancelled the flight");
        }
        
        public override void GetFlightStatus()
        {
            Console.WriteLine("The flight status is: ");
        }

        public int FlightNumber { get; set; }


    }
}


