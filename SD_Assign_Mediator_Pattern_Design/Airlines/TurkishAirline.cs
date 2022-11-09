using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD_Assign_Mediator_Pattern_Design.AbstractClass;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class TurkishAirLine : AbstractAirLine 
    {
        /// <summary>
        /// Properties that airline uses
        /// </summary>
        public string NameOfAirline = "Turkish Airlines";
        public string[] Departures = { "Copenhagen", "London", "Paris" };
        public string[] Arrivals = { "Turkiye", "Hamburg", "USA","Germany" };
        public DateTime CPHGER = new DateTime(2023, 09, 25);
        public DateTime LONHAM = new DateTime(2022, 1, 2);
        public DateTime INDFRANK = new DateTime(2023, 07, 05);
        public double Rate = 3.4;

        /// <summary>
        /// Find and return the existing departure in this airline
        /// </summary>
        /// <param name="departure"></param>
        /// <returns></returns>
        public override string FindDeparture(string departure)
        {
            for (int i = 0; i < Departures.Length; i++)
            {
                if (Departures[i] == departure)
                    return Departures[i];
            }
            return "";
        }

        /// <summary>
        /// Find and return the existing arrival in this airline
        /// </summary>
        /// <param name="arrival"></param>
        /// <returns></returns>
        public override string FindArrival(string arrival)
        {
            for (int i = 0; i < Arrivals.Length; i++)
            {
                if (Arrivals[i] == arrival)
                    return Arrivals[i];
            }
            return "";
        }

        /// <summary>
        /// Find and return the specific date for specific route 
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Calcute the price of ticket for the given departure, arrival and passengers
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <param name="passengers"></param>
        /// <returns></returns>
        public override double CalculatePriceOfRoute(string departure, string arrival, int passengers)
        {
            if (departure == "Copenhagen" && arrival == "Germany")
            {
                Price = passengers * 100;
                return Price;
            }

            return 0;
        }

        /// <summary>
        /// Calculate the travel for time for specific departure and arrival route
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <returns></returns>
        public override int CalculateDurationOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Hamburg")
            {
                this.Duration = 3;
                return Duration;
            }

            return 0;
        }

        /// <summary>
        /// Calculate stops between departure and arrival
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <returns></returns>
        public override int CalculateStopsOfRoute(string departure, string arrival)
        {
            if (departure == "Copenhagen" && arrival == "Germany")
            {
                return this.stops = 3;
            }

            return 0;
        }

        /// <summary>
        /// Make different discounts for customers with different
        /// numer of passengers 
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <param name="passenger"></param>
        /// <returns></returns>
        public override double MakeDiscount(string departure, string arrival, int passenger)
        {
            Price = passenger * 100;
            if (departure == "Copenhagen" && arrival == "Germany" && passenger < 2)
                Discount = ((Price * 2 / 100) + passenger * 1 / 100);
            else if (departure == "Copenhagen" && arrival == "Germany" && passenger > 2)
                Discount = ((Price * 2 / 100) + passenger * 3 / 100);
            return Discount;
        }
    }
}