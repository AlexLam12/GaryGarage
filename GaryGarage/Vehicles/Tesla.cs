using System;

namespace GaryGarage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {
            // method definition omitted
        }
          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Zooom!");
        }
        public void Turn()
        {
            Console.WriteLine($"The Tesla squeels aroung a right turn.");
        }
    }
}