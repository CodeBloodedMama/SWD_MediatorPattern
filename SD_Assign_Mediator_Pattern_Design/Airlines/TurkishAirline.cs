using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class TurkishAirLine : AbstractAirLine 
    {
        public string NameOfAirline = "Turkish Airlines";
        public string[] Departures = { "Copenhagen", "London", "Paris" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA","Germany" };
        public DateTime CPHGER = new DateTime(2023, 09, 25);
        public DateTime LONHAM = new DateTime(2022, 1, 2);
        public DateTime INDFRANK = new DateTime(2023, 07, 05);
        public double Rate = 3.4;


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
            string departure_ = FindDeparture(departure);
            string arrival_ = FindArrival(arrival);
            if (departure_== "Copenhagen" && arrival_ == "Germany")
                return CPHGER;
            if (departure_ == "London" && arrival_ == "Hamburg")
                return LONHAM;
            if (departure_ == "India" && arrival_ == "Frankfurt")
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
                Price = passengers * 100;
                return Price;
            }

            return 0;
        }

        public override int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Duration = 3;
                return Duration;
            }

            return 0;
        }

        public override int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Germany")
            {
                return this.stops = 3;
            }

            return 0;
        }

        /// <summary>
        /// Make discount for customers
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <param name="passenger"></param>
        /// <returns></returns>
        public override double MakeDiscount(string departure, string arrival, int passenger)
        {
            if (departure == "Copenhagen" && arrival == "Germany" && passenger > 1)
                Price = passenger * 100;
            Discount = ((Price * 2 / 100) + passenger * 1 / 100);
            return Discount;
        }
    }
}