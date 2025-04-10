using System;


namespace Vehicle;

class Program
{
    static void Main(string[] args)
    {

        //Del 1
        VehicleHandler vehicleHandler = new VehicleHandler();
        try
        {
            var car = vehicleHandler.CreateVehicle("Volvo", "XC60", 2020, 1500);
            var car1 = vehicleHandler.CreateVehicle("Volvo", "XC90", 2025, 1800);
            vehicleHandler.ListVehicles();

            vehicleHandler.UpdateVehicle(car, brand: "Opel");
            vehicleHandler.ListVehicles();

            vehicleHandler.UpdateVehicle(car1, weight: 2000);
            vehicleHandler.ListVehicles();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
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