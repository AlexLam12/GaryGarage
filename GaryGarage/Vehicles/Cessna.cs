using System;

namespace GaryGarage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. Zooom!");
        }

        public void Turn()
        {
            Console.WriteLine($"The cool car turn cooly");
        }
    }
}