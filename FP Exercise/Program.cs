using System;

namespace FP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires you choose to have for your vehicle of choice.");
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
