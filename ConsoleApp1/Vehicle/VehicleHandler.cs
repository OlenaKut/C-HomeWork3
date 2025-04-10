using System;
using System.Collections.Generic;

namespace Vehicle;
public class VehicleHandler
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public Vehicle CreateVehicle(string brand, string model, int year, double weight)
    {
        var vehicle = new Vehicle
        {
            Brand = brand,
            Model = model,
            Year = year,
            Weight = weight
        };
        vehicles.Add(vehicle);
        return vehicle;
    }

    public void UpdateVehicle(Vehicle vehicle, string? brand = null, string? model = null, int? year = null, double? weight = null)
    {
        if (brand != null) vehicle.Brand = brand;
        if (model != null) vehicle.Model = model;
        if (year.HasValue) vehicle.Year = year.Value;
        if (weight.HasValue) vehicle.Weight = weight.Value;
    }

    public void ListVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles registered.");
            return;
        }

        foreach (var v in vehicles)
        {
            Console.WriteLine(v);
        }
    }
}
