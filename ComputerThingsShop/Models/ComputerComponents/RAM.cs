using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class RAM : ComputerComponent
    {
        private int latency;
        private int memoryCapasity;
        private int frequency;

        public int MemoryCapasity
        {
            get => memoryCapasity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    memoryCapasity = value;
            }
        }
        public string Type { get; set; }
        public bool PassiveCooling { get; set; }
        public int Frequency
        {
            get => frequency;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    frequency = value;
            }
        }
        public bool Overclocking { get; set; }
        public int Latency
        {
            get => latency;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    latency = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            result += $"Memory capasity: {MemoryCapasity}Gb \n";
            result += $"Type: {Type}\n";
            result += "Passive cooling: ";
            result += (PassiveCooling) ? "Yes\n" : "No\n";
            result += $"Frequency: {Frequency}Hz\n";
            result += "Overclocking: ";
            result += (Overclocking) ? "Yes\n" : "No\n";
            result += $"Latency: {Latency}\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.RAMs.FirstOrDefault(item => item.ID == this.ID);
                boughtItem.Count = (boughtItem != null) ? boughtItem.Count - 1 : boughtItem.Count;
                context.Orders.Add(new Order()
                {
                    UserName = MainWindow.User.Name,
                    UserSurname = MainWindow.User.Surname,
                    UserPhoneNumber = MainWindow.User.PhoneNumber,
                    ComponentBrand = boughtItem.Brand,
                    ComponentModel = boughtItem.Model,
                    ComponentPrice = boughtItem.Price
                });
                context.SaveChanges();
            }
        }
    }
}
