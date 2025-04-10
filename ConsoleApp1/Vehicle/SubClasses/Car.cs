using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Vehicle.SubClasses;


public class Car : Vehicle, ICleanable
{

    public int NumberOfDoors { get; set; }
    public override string StartEngine()
    {
        return "Car engine starts with a roar.";
    }

    public override string Stats()
    {
        return $"{Brand} {Model} ({Year}), {Weight}kg, Doors: {NumberOfDoors}";
    }

    public void Clean()
    {
        Console.WriteLine("Cleaning the car: vacuuming interior and washing exterior.");
    }
}
