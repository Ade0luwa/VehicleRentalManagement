using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    class Motorcycle : Vehicle
    {
        // Specific motorcycle properties
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        // Overriding DisplayDetails() method to display both common vehicle properties and motorcycle specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // This displays the common vehicle properties

            // This displays the motorcycle specific properties
            Console.WriteLine("The motorcycle specific details are:");
            Console.WriteLine($"Motorcycle engine capacity: {EngineCapacity}");
            Console.WriteLine($"Type of fuel: {FuelType}");
            Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}\n");
        }
    }
}
