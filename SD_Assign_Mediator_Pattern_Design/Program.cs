using SD_Assign_Mediator_Pattern_Design.Mediator;

TravelAgency travelAgency = new TravelAgency();

Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Welcome to Our Travel Agency");
Console.WriteLine();
Console.WriteLine("----------------------------------");
Console.WriteLine("Press A to see the list of all airlines \n Press B to book ticket");
char Character = Convert.ToChar(Console.ReadLine());

switch (Character)
{
    case 'A':
        travelAgency.FindAirLines();
        break;
    case 'B':
        Console.WriteLine("Enter your departure : ");
        string Departure = Console.ReadLine();
        Console.WriteLine("Enter your Arrival : ");
        string Arrival = Console.ReadLine();
        Console.WriteLine("Enter the number of Passenger : ");
        int NumberOfPassenger = Convert.ToInt32(Console.ReadLine());
        int NumberOfPassengers = travelAgency.CalculateNumberOfPassenger(NumberOfPassenger);
        travelAgency.FindCheapestAndFastestFlight(Departure, Arrival,NumberOfPassengers);
        break;
}


