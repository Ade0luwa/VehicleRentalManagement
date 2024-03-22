using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    class Truck : Vehicle
    {
        // Specific truck properties
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        public Truck(string model, string manufacturer, int year, double rentalPrice, int capacity, string truckType, bool fourWheelDrive) : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Overriding DisplayDetails() method to display both common vehicle properties and truck specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // This displays the common vehicle properties

            // This displays the truck specific properties
            Console.WriteLine("The truck specific details are:");
            Console.WriteLine($"Truck Capacity: {Capacity}");
            Console.WriteLine($"Type of truck: {TruckType}");
            Console.WriteLine($"Four wheel drive: {(FourWheelDrive ? "Yes" : "No")}\n");
        }
    }
}
