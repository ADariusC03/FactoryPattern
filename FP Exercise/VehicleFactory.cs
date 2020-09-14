using System;
using System.Collections.Generic;
using System.Text;

namespace FP_Exercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcylce();
                case 4:
                    return new Car();
                case 8:
                    return new BigRig();

                default:
                    return new Car();
            }

        }
    }
}
