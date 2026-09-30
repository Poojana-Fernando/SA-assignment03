using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; } = string.Empty;

        public EntertainmentRobot()
        {
        }

        private EntertainmentRobot(EntertainmentRobot other)
        {
            ModelName = other.ModelName;
            BatteryCapacityHours = other.BatteryCapacityHours;
            SoftwareVersion = other.SoftwareVersion;
            EntertainmentFeature = other.EntertainmentFeature;
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(this);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" EntertainmentFeature: {EntertainmentFeature}");
        }
    }
}
