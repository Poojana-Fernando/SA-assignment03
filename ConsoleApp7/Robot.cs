using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public abstract class Robot
    {
        
        public string ModelName { get; set; } = string.Empty;
        public double BatteryCapacityHours { get; set; }
        public string SoftwareVersion { get; set; } = string.Empty;

       
        public abstract Robot Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {ModelName}, Battery: {BatteryCapacityHours}h, SW: {SoftwareVersion}");
        }
    }
}
