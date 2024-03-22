// Program.cs
using System;
using VehicleRental;

class Program
{
    static void Main(string[] args)
    {
        string applicationName = "Ade Vehicle Rental System";
        bool actionsChoice = true;

        Console.WriteLine($"Welcome to {applicationName}");
        // Creating rental agency
        RentalAgency agency = new RentalAgency(4);

        while(actionsChoice)
        {
            Console.WriteLine("Choose an action from the below menu options");
            Console.WriteLine("Main Menu Options:");
            Console.WriteLine("1. Add vehicles to inventory");
            Console.WriteLine("2. Display all vehicles in the inventory ");
            Console.WriteLine("3. Remove vehicles from inventory");
            Console.WriteLine("4. Rent a vehicle from inventory");
            Console.WriteLine("5. Exit the application");
            int actionSelected = Convert.ToInt32(Console.ReadLine());

            switch(actionSelected)
            {
                case 1:
                    agency.AddVehicleToInventory();
                    break;

                case 2:
                    agency.DisplayInventory();
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    Console.WriteLine($"Thank you for using {applicationName}. Hope to see you soon");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;


            }
        }


    }
}