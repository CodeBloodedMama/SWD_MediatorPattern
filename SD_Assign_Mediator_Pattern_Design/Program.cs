using SD_Assign_Mediator_Pattern_Design;
using SD_Assign_Mediator_Pattern_Design.Interface;
using SD_Assign_Mediator_Pattern_Design.Mediator;

TravelAgency travelAgency = new TravelAgency();
ICustomer customer = new Customer(travelAgency);
string character = "";
string Departure = "Copenhagen";
string Arrival = "Germany";
int Passengers = 3;

Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("You can help customer by insert characters to book the best airline :)");
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Press A to show the list of all airlines for customer\n" +
                  "Press C to show the cheapest ticket\n" +
                  "Press S show the shortest route for customer\n" +
                  "Press F to show cheapest and fastest flight for customer\n" +
                  "Press T to show top rated airlines for customer\n" +
                  "Press D to show discount for customer\n" +
                  "Press R to show stops between depature and arrival for customer\n" +
                  "Press G to show departure time for customer\n" +
                  "Press B to book ticket for customer" +
                  "Press E to exit the screen");
while (character != "E")
{
    character  = Console.ReadLine();
    switch (character)
    {
        case "A":
        case "a":
            customer.FindAllAirlines();
            break;
        case "C":
        case "c":
            customer.AskTravelAgencyForCheapestFlight(Departure,Arrival,Passengers);
            break;
        case "S":
        case "s":
            customer.AskTravelAgencyForStopsBetweenDepartureAndArrival(Departure,Arrival);
            break;
        case "F":
        case "f":
            customer.AskTravelAgencyForCheapAndFastFlight(Departure, Arrival, Passengers);
            break;
        case "D":
        case "d":
            customer.AskTravelAgencyForDiscount(Departure, Arrival, Passengers);
            break;
        case "T":
        case "t":
            customer.AskTravelAgencyForTopRatedAirLines();
            break;
        case "R":
        case "r":
            customer.AskTravelAgencyForFastestRoute(Departure, Arrival);
            break;
        case "G":
        case "g":
            customer.AskForDepartureTime(Departure,Arrival);
            break;
        case "B":
        case "b":
            customer.BookTicket(Departure,Arrival,Passengers);
            break;
        default:
            break;
    }
}




