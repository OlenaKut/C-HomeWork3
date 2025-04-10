using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Vehicle.SubClasses;

public class Truck : Vehicle, ICleanable
{
    public double CargoCapacity { get; set; } // in kg

    public override string StartEngine()
    {
        return "Truck engine rumbles to life.";
    }

    public override string Stats()
    {
        return $"{Brand} {Model} ({Year}), {Weight}kg, Cargo Capacity: {CargoCapacity}kg";
    }

    public void Clean()
    {
        Console.WriteLine("Cleaning the truck: washing exterior and checking cargo area.");
    }
}