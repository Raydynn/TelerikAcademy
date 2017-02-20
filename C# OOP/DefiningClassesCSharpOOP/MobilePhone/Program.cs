using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        public Display Display { get; set; }
        public Battery Battery { get; set; }

        public override string ToString()
        {
            return "Display model: " + Display.Model + Environment.NewLine +
                "Display manufacturer: " + Display.Manufacturer + Environment.NewLine +
                "Battery model: " + Battery.Model + Environment.NewLine +
                "Battery manufacturer: " + Battery.Manufacturer + Environment.NewLine +
                "Battery type: " + Battery.BatteryType;
        }

        public GSM(Display screen, Battery battery)
        {
            this.Display = screen;
            this.Battery = battery;
        }
    }

    public class Display
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Display(string model, string manufacturer)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }
    }

    public class Battery
    {
        private enum BatteryTypeMaterials { NiCd, NiMH, LeadAcid, LiIon };
        public string BatteryType { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Battery(string model, string manufacturer, int batteryType)
        {
            this.BatteryType = Enum.GetName(typeof(BatteryTypeMaterials), batteryType);
            this.Manufacturer = manufacturer;
            this.Model = model;
        }
    }

        class Program
    {
        static void Main()
        {
            Console.WriteLine("For battery type enter \"0\" for NiCd, \"1\" for NiMH, \"2\" for Lead-Acid, \"3\" for Li-ion.");

            Battery bat = new Battery("Acer", "Prase", 2);
            Display screen = new Display("Acer", "Prase");

            GSM phone = new GSM(screen, bat);

            Console.WriteLine(phone);
        }
    }
}
