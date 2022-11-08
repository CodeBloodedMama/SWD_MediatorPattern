using SD_Assign_Mediator_Pattern_Design;
using SD_Assign_Mediator_Pattern_Design.Interface;
using SD_Assign_Mediator_Pattern_Design.Mediator;

namespace SD_Assign_Mediator_Pattern_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            ITravelAgency travelAgency = new TravelAgency();
            ICustomer customer = new Customer(travelAgency);
            //customer.AskTravelAgencyForTopRatedAirLines();
            //customer.AskTravelAgencyForCheapestFlight("Oslo", "London", 2);
            //customer.AskTravelAgencyForCheapAndFastFlight("Oslo", "London", 2);
            //customer.AskTravelAgencyForDiscount("Oslo", "London", 2);
            //customer.AskTravelAgencyForFastestRoute("Oslo", "London");
            //customer.AskTravelAgencyForStopsBetweenDepartureAndArrival("Oslo", "London");
            //customer.AddNumberOfPassengers(2);



            Console.WriteLine("Welcome to Travel Agency");

            Console.WriteLine("Choose your option: " +
                "1. Find Cheapest Flight " +
                "2. Find Cheapest and Fastest Flight " +
                "3. Find Discount on Flights " +
                "4. Find Shortest Route " +
                "5. Find Route Stops " +
                "6. Find Top Rated Air Lines");

            int option = Convert.ToInt32(Console.ReadLine());


            switch{

                case 1:
                    customer.AskTravelAgencyForCheapestFlight();

                        break;

                case 2:
                    customer.AskTravelAgencyForCheapAndFastFlight("London", "Paris", 2);

                        break;

                case 3:
                    customer.AskTravelAgencyForDiscount("London", "Paris", 2);

                        break;

                case 4:
                    customer.AskTravelAgencyForFastestRoute("London", "Paris");

                        break;

                case 5:
                    customer.AskTravelAgencyForStopsBetweenDepartureAndArrival("London", "Paris");

                        break;

        }
    }
    }
}





//customer.AskTravelAgencyForCheapestFlight("Copenhagen", "London", 2);


//customer.AskTravelAgencyForCheapAndFastFlight("Copenhagen", "London", 2);


//customer.AskTravelAgencyForDiscount("Copenhagen", "London", 2);


//customer.AskTravelAgencyForFastestRoute("Copenhagen", "London");


//customer.AskTravelAgencyForStopsBetweenDepartureAndArrival("Copenhagen", "London");


//Console.ReadLine();







