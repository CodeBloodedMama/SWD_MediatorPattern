﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design.Airlines
{
    public class TurkishAirLine : AbstractAirLine 
    {
        public override void CancelFlight()
        {
            Console.WriteLine("Turkish Airline has cancelled the flight");
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