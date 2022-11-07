using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SD_Assign_Mediator_Pattern_Design.Mediator
{
    public class TravelAgency 
    {
        private List<AbstractAirLine> _airlines = new List<AbstractAirLine>();
        private List<Customer> _customers = new List<Customer>();

        public void AddAirLine(AbstractAirLine airline)
        {
            _airlines.Add(airline);
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void FindCheapestTickets(string departure, string arrival)
        {
            Console.WriteLine("The cheapest tickets are: ");
        }

        public void FindShortestRute(string departure, string arrival)
        {
            Console.WriteLine("The shortest rute is: ");
        }

        public void FindCheapestAndFastestFlight(string departure, string arrival)
        {
            Console.WriteLine("The cheapest and fastest flight is: ");
        }

        public void FindAirLines()
        {
            Console.WriteLine("The airlines are: ");
        }

        public void FindTopRatetAirLines()
        {
            Console.WriteLine("The top rated airlines are: ");
        }

        public void FindDiscountOnFlights(string departure, string arrival, int Date)
        {
            Console.WriteLine("The discount on flights are: ");
        }

        public void FindDayFlights(string departure, string arrival)
        {
            Console.WriteLine("The day flights are: ");
        }

        public void FindNightFlights(string departure, string arrival)
        {
            Console.WriteLine("The night flights are: ");
        }

        public void HandlerInqueryFromCustomer()
        {
            Console.WriteLine("The inquery from customer is: ");
        }

        public void HandlePaymentFromCustomer()
        {
            Console.WriteLine("The payment from customer is: ");
        }


    }
}