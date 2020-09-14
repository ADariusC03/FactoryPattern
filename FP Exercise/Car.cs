using System;
using System.Collections.Generic;
using System.Text;

namespace FP_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {

        }
        public void Drive()
        {
            Console.WriteLine("The car is now driving. Drive Safe!");
            Console.WriteLine("Skrtt Skrrrrrtttt Skrrttttt");
        }
    }
}
