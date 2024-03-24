using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VehicleRental
{
    class RentalAgency
    {
        private Vehicle[] Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        public RentalAgency(int inventorySize)
        {
            Fleet = new Vehicle[inventorySize];
        }

        // Method to add vehicle to vehicleQuantity
        public void AddVehicleToInventory()
        {
            Console.WriteLine($"You can only add a maximum of {Fleet.Length} vehicles to the fleet");

            // Find the next available index in the fleet
            int nextIndex = 0;
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    nextIndex = i;
                    break;
                }
            }

            // Prompt user to select the type of vehicle
            Console.WriteLine("Select the type of vehicle to add:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Motorcycle");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            // Prompt user to enter the number of vehicles to add
            Console.Write("Enter the number of vehicles to add: ");
            int numVehicles = int.Parse(Console.ReadLine());

            // Check if the number of vehicles selected is greater than the current fleet size
            if (numVehicles > Fleet.Length - nextIndex)
            {
                Console.WriteLine("Unable to add more vehicles than the fleet size.");
                return;
            }

            // Add the selected number of vehicles to the fleet
            for (int i = nextIndex; i < nextIndex + numVehicles; i++)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Enter details for Car {i + 1}:");
                        Fleet[i] = CreateCar();
                        break;

                    case 2:
                        Console.WriteLine($"Enter details for Truck {i + 1}:");
                        Fleet[i] = CreateTruck();
                        break;

                    case 3:
                        Console.WriteLine($"Enter details for Motorcycle {i + 1}:");
                        Fleet[i] = CreateMotorcycle();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private Car CreateCar()
        {
            //user is asked to enter car details
            string carModel = "";
            while (string.IsNullOrEmpty(carModel))
            {
                Console.Write("Model: ");
                carModel = Console.ReadLine();
            }

            string carManufacturer = "";
            while (string.IsNullOrEmpty(carManufacturer))
            {
                Console.Write("Manufacturer: ");
                carManufacturer = Console.ReadLine();
            }

            int carYear = 0;
            while (carYear == 0)
            {
                Console.Write("Year: ");
                int.TryParse(Console.ReadLine(), out carYear);
            }

            double carRentalPrice = 0;
            while (carRentalPrice == 0)
            {
                Console.Write("Rental Price: ");
                double.TryParse(Console.ReadLine(), out carRentalPrice);
            }

            int carSeats = 0;
            while (carSeats == 0)
            {
                Console.Write("Seats: ");
                int.TryParse(Console.ReadLine(), out carSeats);
            }

            string carEngineType = "";
            while (string.IsNullOrEmpty(carEngineType))
            {
                Console.Write("Engine Type: ");
                carEngineType = Console.ReadLine();
            }

            string carTransmission = "";
            while (string.IsNullOrEmpty(carTransmission))
            {
                Console.Write("Transmission: ");
                carTransmission = Console.ReadLine();
            }

            bool carConvertible;
            string convertibleInput;
            do
            {
                Console.Write("Is the vehicle a convertible (true/false): ");
                convertibleInput = Console.ReadLine().ToLower();
            } while (convertibleInput != "true" && convertibleInput != "false");

            // Parse the convertibleInput to bool
            bool.TryParse(convertibleInput, out carConvertible);
            Console.WriteLine($"\nCongratulations!!! You have successfully added {carModel} to your fleet\n");
            return new Car(carModel, carManufacturer, carYear, carRentalPrice, carSeats, carEngineType, carTransmission, carConvertible);
        }

        private Truck CreateTruck()
        {
            string truckModel = "";
            while (string.IsNullOrEmpty(truckModel))
            {
                Console.Write("Model: ");
                truckModel = Console.ReadLine();
            }

            string truckManufacturer = "";
            while (string.IsNullOrEmpty(truckManufacturer))
            {
                Console.Write("Manufacturer: ");
                truckManufacturer = Console.ReadLine();
            }

            int truckYear = 0;
            while (truckYear == 0)
            {
                Console.Write("Year: ");
                int.TryParse(Console.ReadLine(), out truckYear);
            }

            double truckRentalPrice = 0;
            while (truckRentalPrice == 0)
            {
                Console.Write("Rental Price: ");
                double.TryParse(Console.ReadLine(), out truckRentalPrice);
            }

            int truckCapacity = 0;
            while (truckCapacity == 0)
            {
                Console.Write("Capacity: ");
                int.TryParse(Console.ReadLine(), out truckCapacity);
            }

            string truckType = "";
            while (string.IsNullOrEmpty(truckType))
            {
                Console.Write("Truck Type: ");
                truckType = Console.ReadLine();
            }

            bool truckFourWheelDrive = false;
            while (!truckFourWheelDrive)
            {
                Console.Write("Four-Wheel Drive (true/false): ");
                bool.TryParse(Console.ReadLine(), out truckFourWheelDrive);
            }
            Console.WriteLine($"\nCongratulations!!! You have successfully added {truckModel} to your fleet\n");
            return new Truck(truckModel, truckManufacturer, truckYear, truckRentalPrice, truckCapacity, truckType, truckFourWheelDrive);
        }

        private Motorcycle CreateMotorcycle()
        {
            string bikeModel = "";
            while (string.IsNullOrEmpty(bikeModel))
            {
                Console.Write("Model: ");
                bikeModel = Console.ReadLine();
            }

            string bikeManufacturer = "";
            while (string.IsNullOrEmpty(bikeManufacturer))
            {
                Console.Write("Manufacturer: ");
                bikeManufacturer = Console.ReadLine();
            }

            int bikeYear = 0;
            while (bikeYear == 0)
            {
                Console.Write("Year: ");
                int.TryParse(Console.ReadLine(), out bikeYear);
            }

            double bikeRentalPrice = 0;
            while (bikeRentalPrice == 0)
            {
                Console.Write("Rental Price: ");
                double.TryParse(Console.ReadLine(), out bikeRentalPrice);
            }

            int bikeEngineCapacity = 0;
            while (bikeEngineCapacity == 0)
            {
                Console.Write("Engine Capacity: ");
                int.TryParse(Console.ReadLine(), out bikeEngineCapacity);
            }

            string bikeFuelType = "";
            while (string.IsNullOrEmpty(bikeFuelType))
            {
                Console.Write("Fuel Type: ");
                bikeFuelType = Console.ReadLine();
            }

            bool bikeHasFairing = false;
            while (!bikeHasFairing)
            {
                Console.Write("Has Fairing (true/false): ");
                bool.TryParse(Console.ReadLine(), out bikeHasFairing);
            }
            Console.WriteLine($"\nCongratulations!!! You have successfully added {bikeModel} to your fleet\n");
            return new Motorcycle(bikeModel, bikeManufacturer, bikeYear, bikeRentalPrice, bikeEngineCapacity, bikeFuelType, bikeHasFairing);
        }


        // Method to remove vehicle from fleet
        public void RemoveVehicleFromInventory()
        {
            // User is asked to enter the index of the vehicle to remove
            Console.Write("Enter the index of the vehicle to remove: ");
            int indexToRemove = int.Parse(Console.ReadLine());

            // Checks to confirm if the index entered is valid
            if (indexToRemove < 0 || indexToRemove >= Fleet.Length || Fleet[indexToRemove] == null)
            {
                Console.WriteLine("There is no vehicle found at the selected index. Try again!!\n");
                return;
            }

            // Remove the vehicle from the fleet
            Fleet[indexToRemove] = null;

            // Shift vehicles in the fleet array to fill the gap
            for (int i = indexToRemove; i < Fleet.Length - 1; i++)
            {
                Fleet[i] = Fleet[i + 1];
            }
            // Clear the last slot in the array
            Fleet[Fleet.Length - 1] = null;

            Console.WriteLine("\nVehicle has been removed from inventory.\n");
        }


        // Method to rent vehicle
        public void RentVehicle()
        {
            // Prompt user to enter the index of the vehicle to be rented
            Console.Write("Enter the index of the vehicle to be rented: ");
            int index = int.Parse(Console.ReadLine());

            // Checks to confirm if the index entered is valid
            if (index < 0 || index >= Fleet.Length || Fleet[index] == null)
            {
                Console.WriteLine("There is no vehicle found at the selected index. Try again!!\n");
                return;
            }

            // Display details of the selected vehicle
            Fleet[index].DisplayDetails();

            // Prompts user to enter the duration of the rental in months
            Console.Write("\nEnter the duration of the rental (in months): ");
            int months = int.Parse(Console.ReadLine());

            // Calculate rental cost
            double rentalCost = Fleet[index].RentalPrice * months;

            // Display rental cost to the user
            Console.WriteLine($"\nRental cost for {months} months: ${rentalCost}");

            // Ask user for confirmation
            Console.Write("\nDo you want to proceed with the rental? (yes/No): ");
            string confirmation = Console.ReadLine().ToLower();

            // If user confirms, proceed with the rental
            if (confirmation == "yes")
            {
                // Update total revenue
                TotalRevenue += rentalCost;
                // Remove the rented vehicle from the fleet
                Fleet[index] = null;
                Console.WriteLine($"\nCongratulations you have successfully rented the vehicle for {months} months");
                GetTotalRevenue();
            }
            else
            {
                Console.WriteLine("Rental process cancelled.");
            }
        }

        //Method to display the total revenue earned
        public void GetTotalRevenue()
        {
            Console.WriteLine($"Total Revenue from rental: ${TotalRevenue}");
        }

        // Method to display all items in the inventory
        public void DisplayInventory()
        {
            Console.WriteLine($"Your fleet has {Fleet.Length} slots.\n ");

            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    Console.WriteLine($"No vehicles currently in slot {i + 1}.");
                }
                else if (Fleet[i] != null)
                {
                    Console.WriteLine($"Vehicle {i + 1}:");
                    Fleet[i].DisplayDetails();
                    Console.WriteLine();
                }

            }

        }

    }
}
