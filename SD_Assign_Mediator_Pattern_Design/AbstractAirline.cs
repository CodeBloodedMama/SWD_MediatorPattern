using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design
{
    public abstract class AbstractAirLine
    {
        public int FirstClass { get; set; }
        public int EconomyClass { get; set; }
        public int Insurance { get; set; }
        public int ExtraLuggage { get; set; }
        public int Services { get; set; }
        public int Property { get; set; }
        public int Crew { get; set; }
        public int Rate { get; set; }
        
        public int MemberBenifits { get; set; }
        public int Discount { get; set; }
        public int Tickets { get; set; }
        public int ShortestRute { get; set; }
        public bool FullBooked { get; set; }

        enum DayOrNight
        {
            Day,
            Night
        }
        

        public abstract void ChangeFlight();
        public abstract void CancelFlight();

        public abstract void GetFlightStatus();

        

        
    }
}