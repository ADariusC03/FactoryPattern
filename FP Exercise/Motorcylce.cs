using System;
using System.Collections.Generic;
using System.Text;

namespace FP_Exercise
{
    public class Motorcylce : IVehicle
    {
        public Motorcylce()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The motorcylce is now revving up. Wear a helmet now!");
            Console.WriteLine("Vroommmmm Vrommmmm!");
        }
    }
}
