using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Vehicle.SubClasses;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override string StartEngine()
    {
        return "Motorcycle engine starts with a vroom.";
    }

    public override string Stats()
    {
        return $"{Brand} {Model} ({Year}), {Weight}kg, Sidecar: {(HasSidecar ? "Yes" : "No")}";
    }
}
