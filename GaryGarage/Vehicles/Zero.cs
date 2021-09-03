using System;

namespace GaryGarage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla is now charged to {this.BatteryKWh}KWh.");
        }
          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Zooom!");
        }
         public void Turn()
        {
            Console.WriteLine($"The vehicle carefully turns right.");
        }
    }
}