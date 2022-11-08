using System.Net.Mime;
using SD_Assign_Mediator_Pattern_Design;
using SD_Assign_Mediator_Pattern_Design.Interface;
using SD_Assign_Mediator_Pattern_Design.Mediator;

TravelAgency travelAgency = new TravelAgency();
Customer customer = new Customer(travelAgency);
travelAgency.customer1 = customer;
string character = "";


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
                  "Press E to exit the screen");
while (character != "E")
{
    character = Console.ReadLine();
    if (character == "E")
    {
        Console.WriteLine("Program exited");
        Environment.Exit(1);
    }
    customer.Send(character);
}

Console.WriteLine("Program exited");
Environment.Exit(1);




