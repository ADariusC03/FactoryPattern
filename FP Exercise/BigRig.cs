using System;
using System.Collections.Generic;
using System.Text;

namespace FP_Exercise
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The BigRig is now moving along to make your delivery on time.");
            Console.WriteLine("bhunnn Bu Bu Bhunnnn!");
        }
    }
}
