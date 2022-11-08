using SD_Assign_Mediator_Pattern_Design;
using SD_Assign_Mediator_Pattern_Design.Interface;
using SD_Assign_Mediator_Pattern_Design.Mediator;

TravelAgency travelAgency = new TravelAgency();
ICustomer customer = new Customer(travelAgency);





customer.AddNumberOfPassengers(3);

customer.AskTravelAgencyForCheapestFlight("Oslo", "London", 3);

customer.AskTravelAgencyForCheapAndFastFlight("Oslo", "London", 3);

customer.AskTravelAgencyForDiscount("Oslo", "London", 3);

customer.AskTravelAgencyForTopRatedAirLines();

customer.AskTravelAgencyForFastestRoute("Oslo", "London");


travelAgency.FindRouteStops("copenhagen", "dubai");






