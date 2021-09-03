using System;
using System.Collections.Generic;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = 4,
                BatteryKWh = 175.25
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 2,
                FuelCapacity = 15.25
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                BatteryKWh = 250.50
            };

            fxs.Drive();
            fxs.Turn();
            modelS.Drive();
            mx410.Drive();
            mx410.Turn();
        }
    }
}
