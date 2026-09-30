using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; } = string.Empty;

        public ServiceRobot()
        {
        }

        private ServiceRobot(ServiceRobot other)
        {
            ModelName = other.ModelName;
            BatteryCapacityHours = other.BatteryCapacityHours;
            SoftwareVersion = other.SoftwareVersion;
            ServiceTask = other.ServiceTask;
        }

        public override Robot Clone()
        {
            
            return new ServiceRobot(this);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" ServiceTask: {ServiceTask}");
        }
    }
}
