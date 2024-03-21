using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    class Vehicle
    {
        //getting and setting the vehicle's properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        
        public Vehicle(string model, string manufacturer, int year, double rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Method to display the vehicle's details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The vehicle details are:\n");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice:C}");
        }
    }
}