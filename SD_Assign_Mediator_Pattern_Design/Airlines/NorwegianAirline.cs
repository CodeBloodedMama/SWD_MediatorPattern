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
        public DateTime CPHGER = new DateTime(2023, 12, 25);
        public DateTime LONHAM = new DateTime(2022, 11, 2);
        public DateTime INDFRANK = new DateTime(2023, 03, 05);
        public int AirlinesAvailableSeats = 50;

        public double CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                Price = passengers * 200;
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

        public double MakeDiscount(string departure, string arrival, int passenger)
        {
            if (departure == "Copenhagen" && arrival == "Germany" && passenger > 1)
                Price = passenger * 150;
            Discount = ((Price * 2 / 100) + passenger * 1 / 100);
            return Discount;
        }

        public override void CancelFlight()
        {
            Console.WriteLine("Norwegian Airline has cancelled the flight");
        }

     public override void GetFlightStatus()
        {
            Console.WriteLine("The flight status is: ");
        }
    }
}
