
namespace Vehicle;

class Program
{
    static void Main(string[] args)
    {
        VehicleHandler vehicleHandler = new VehicleHandler();

        try
        {
            var car = vehicleHandler.CreateVehicle("Volvo", "XC60", 2020, 1500);
            var car1 = vehicleHandler.CreateVehicle("Volvo", "XC90", 2025, 1800);
            //vehicleHandler.ListVehicles();

            vehicleHandler.UpdateVehicle(car, weight: 1700);
            vehicleHandler.ListVehicles();

            vehicleHandler.UpdateVehicle(car1, weight: 2000);
            vehicleHandler.ListVehicles();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}