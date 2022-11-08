using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class KLMAirline : AbstractAirLine
    {

        public string[] Departures = { "Copenhagen", "London", "Paris" };
        public string[] Arrivals = { "Sweden", "Norway", "London" };
        public string NameOfAirline = "KLMAirline";
        public double Rate = 2.4;


        public int CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Sweden")
            {
                this.Price = passengers * 75;
                return Price;
            }

            return 0;
        }

        public int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Sweden")
            {
                this.Duration = 1;
                return Duration;
            }

            return 0;
        }

        public int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Sweden")
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
