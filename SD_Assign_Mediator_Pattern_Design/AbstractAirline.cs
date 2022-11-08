using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD_Assign_Mediator_Pattern_Design
{
    public abstract class AbstractAirLine
    {
        int FirstClass { get; set; }
        int EconomyClass { get; set; }
        int Insurance { get; set; }
        int ExtraLuggage { get; set; }
        int Services { get; set; }
        int Property { get; set; }
        int Crew { get; set; }
        int MemberBenifits { get; set; }

        public Interface.ITravelAgency ITravelAgency
        {
            get => default;
            set
            {
            }
        }

        public virtual void ChangeFlight();
        public virtual void CancelFlight();
    }
}