
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal static class Program
    {
        private static void Main()
        {
            
            var servicePrototype = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacityHours = 8,
                SoftwareVersion = "1.0.0",
                ServiceTask = "Patient Assistance"
            };

            var industrialPrototype = new IndustrialRobot
            {
                ModelName = "IR-900",
                BatteryCapacityHours = 24,
                SoftwareVersion = "3.2.1",
                IndustrialTask = "Welding"
            };

            var entertainmentPrototype = new EntertainmentRobot
            {
                ModelName = "ER-7",
                BatteryCapacityHours = 6,
                SoftwareVersion = "2.5.0",
                EntertainmentFeature = "Interactive Dance"
            };

           
            var order1 = (ServiceRobot)servicePrototype.Clone();
            order1.ModelName = "SR-100-CUST-001";
            order1.BatteryCapacityHours = 10; 
            order1.SoftwareVersion = "1.1.0"; 

            var order2 = (IndustrialRobot)industrialPrototype.Clone();
            order2.ModelName = "IR-900-UNIT-12";
            order2.SoftwareVersion = "3.3.0";

            var order3 = (EntertainmentRobot)entertainmentPrototype.Clone();
            order3.ModelName = "ER-7-FESTIVAL";
            order3.BatteryCapacityHours = 8;
            order3.EntertainmentFeature = "Laser Show";

            var robots = new Robot[] { order1, order2, order3 };

            Console.WriteLine("Cloned Robots:");
            foreach (var r in robots)
            {
                r.DisplayInfo();
                Console.WriteLine();
            }

            
            var bulk = new List<ServiceRobot>();
            for (int i = 0; i < 5; i++)
            {
                var s = (ServiceRobot)servicePrototype.Clone();
                s.ModelName = $"SR-100-BULK-{i + 1:D3}";
                s.SoftwareVersion = "1.0.1";
                bulk.Add(s);
            }

            Console.WriteLine("Bulk clones:");
            foreach (var b in bulk)
            {
                b.DisplayInfo();
            }
        }
    }
}
