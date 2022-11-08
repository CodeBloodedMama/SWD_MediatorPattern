using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class IranAirline : AbstractAirLine
    {
        public string[] Departures = { "Copenhagen", "London", "Paris" };
        public string[] Arrivals = { "Tehran", "Dubai", "Alanya" };
        public string NameOfAirline = "IranAirline";
        public double Rate = 5.0;

        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Tehran")
            {
                this.Price = passengers * 100;
                return Price;
            }

            return 0;
        }

        public int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Tehran")
            {
                this.Duration = 3;
                return Duration;
            }

            return 0;
        }

        public int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Tehran")
            {
                return this.stops = 3;
            }

            return 0;
        }

        

        public override void CancelFlight()
        {
            Console.WriteLine("Iran Airline has cancelled the flight");
        }

        public override void ChangeFlight()
        {
            Console.WriteLine("The flight has been changed");
        }

        public override void GetFlightStatus()
        {
            Console.WriteLine("The flight status is: ");
        }

        public int FlightNumber { get; set; }


    }
}


