using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.SubClasses;


namespace Vehicle;

class Program
{
    static void Main(string[] args)
    {

        //Del 1, 3
        var handler = new VehicleHandler();

        try
        {
            var car = new Car { Brand = "Volvo", Model = "S60", Year = 2021, Weight = 1500, NumberOfDoors = 4 };
            var car1 = new Car { Brand = "BMW", Model = "TTT", Year = 2012, Weight = 1700, NumberOfDoors = 5 };
            var truck = new Truck { Brand = "Scania", Model = "XTT", Year = 2019, Weight = 7000, CargoCapacity = 12000 };
            var bike = new Motorcycle { Brand = "Harley", Model = "Street 750", Year = 2018, Weight = 220, HasSidecar = false };
            var scooter = new ElectricScooter { Brand = "Xiaomi", Model = "Mi Electric", Year = 2022, Weight = 13, BatteryRange = 30 };

            handler.AddVehicle(car);
            handler.AddVehicle(truck);
            handler.AddVehicle(bike);
            handler.AddVehicle(scooter);
            handler.ListAll();

            handler.UpdateVehicle(car, brand: "Opel");
            handler.ListAll();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating vehicle: {ex.Message}");
        }


        //Del 2
        SystemError systemError = new VehicleSystemError();

        systemError.AddErrorMessage(new SystemError.EngineFailureError());
        systemError.AddErrorMessage(new SystemError.BrakeFailureError());
        systemError.AddErrorMessage(new SystemError.TransmissionError());

        Console.WriteLine("System Errors:");
        systemError.ListErrorMessages();
    }

    public class VehicleSystemError : SystemError
    {
    }

}