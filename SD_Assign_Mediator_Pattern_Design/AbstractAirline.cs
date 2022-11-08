using System;
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
        public static double Price = 0.0;
        public bool Available = true;
        
        public abstract void CancelFlight();
        public abstract void GetFlightStatus();

        

        
    }
}