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
    }
}