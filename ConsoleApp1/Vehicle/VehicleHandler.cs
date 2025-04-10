using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle;
public class VehicleHandler
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ListAll()
    {
        foreach (var v in vehicles)
        {
            Console.WriteLine(v.Stats());
            Console.WriteLine(v.StartEngine());

            if (v is ICleanable cleanable)
            {
                cleanable.Clean();
            }
            Console.WriteLine(new string('-', 40));
        }

    }



    public void UpdateVehicle(Vehicle vehicle, string? brand = null, string? model = null, int? year = null, double? weight = null)
    {
        if (brand != null) vehicle.Brand = brand;
        if (model != null) vehicle.Model = model;
        if (year.HasValue) vehicle.Year = year.Value;
        if (weight.HasValue) vehicle.Weight = weight.Value;
    }

}
