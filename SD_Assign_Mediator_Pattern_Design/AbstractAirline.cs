﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design
{
    public abstract class AbstractAirLine
    {
        //public bool FullBooked { get; set; }

        public int Duration = 0;
        public int stops = 0;
        public static double Discount { get; set; }
        public string NameOfAirline = "";
        public double Rate = 4.4;
        public double Price = 0.0;
        public bool Available = true;


        public abstract double CalculatePriceOfRoute(string departure, string arrival, int passengers);
        public abstract int CalculateDurationOfRoute(string departure, string arrival);
        public abstract int CalculateStopsOfRoute(string departure, string arrival);
        public abstract double MakeDiscount(string departure, string arrival, int passenger);
        public abstract double CalculatePriceForRoute(string departure, string arrival, int passenger);
        public abstract string FindDeparture(string departure);
        public abstract string FindArrival(string arrival);
        public abstract DateTime GetDepartureDate(string departure, string arrival);

        public abstract void CancelFlight();
        public abstract void GetFlightStatus();
        public abstract void GetFlightInfo(string departure, string arrival);
        internal abstract void Notify(string message);
        //public double Rate = ;


    }
}