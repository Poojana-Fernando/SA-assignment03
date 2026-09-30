using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; } = string.Empty;

        public IndustrialRobot()
        {
        }

        private IndustrialRobot(IndustrialRobot other)
        {
            ModelName = other.ModelName;
            BatteryCapacityHours = other.BatteryCapacityHours;
            SoftwareVersion = other.SoftwareVersion;
            IndustrialTask = other.IndustrialTask;
        }

        public override Robot Clone()
        {
            return new IndustrialRobot(this);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" IndustrialTask: {IndustrialTask}");
        }
    }
}
