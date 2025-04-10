using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Vehicle.SubClasses;
public class ElectricScooter : Vehicle
{
    public int BatteryRange { get; set; } // in km

    public override string StartEngine()
    {
        return "Electric scooter powers on silently.";
    }

    public override string Stats()
    {
        return $"{Brand} {Model} ({Year}), {Weight}kg, Battery Range: {BatteryRange}km";
    }
}