using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    class Car : Vehicle
    {
        // Specific car properties
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        public Car(string model, string manufacturer, int year, double rentalPrice, int seats, string engineType, string transmission, bool convertible) : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }

        // Overriding DisplayDetails() method to display both common vehicle properties and car-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // This displays the common vehicle properties

            // This displays the car specific properties
            Console.WriteLine("The car specific details are:\n");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {(Convertible ? "Yes" : "No")}");
        }


    }
}
