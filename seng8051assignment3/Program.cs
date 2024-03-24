using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car
        {
            Model = "Civic",
            Manufacturer = "Honda",
            Year = 2022,
            RentalPrice = 50,
            Seats = 5,
            EngineType = "Gasoline",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2021,
            RentalPrice = 80,
            Capacity = "Half-Ton",
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Ninja",
            Manufacturer = "Kawasaki",
            Year = 2023,
            RentalPrice = 30,
            EngineCapacity = 1000,
            FuelType = "Petrol",
            HasFairing = true
        };

        RentalAgency rentalAgency = new RentalAgency(10);
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        Console.WriteLine("Details of Vehicles in Fleet:");
        foreach (Vehicle vehicle in rentalAgency.Fleet)
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }

        Console.WriteLine("Renting a vehicle...");
        rentalAgency.RentVehicle(truck);

        Console.WriteLine("Total Revenue: " + rentalAgency.TotalRevenue);
    }
}
