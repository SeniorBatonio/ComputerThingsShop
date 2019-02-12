using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class CPU : ComputerComponent
    {
        private int cores;
        private int technicalProcess;
        private int heatTransfer;
        private double frequency;

        public string SocketType { get; set; }
        public bool Overklocking { get; set; }
        public int Cores
        {
            get => cores;
            set
            {
                if (value< 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    cores = value;
            }
        }
        public bool EmbeddedGPU { get; set; }
        public int TechnicalProcess
        {
            get => technicalProcess;
            set
            {
                if (value< 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    technicalProcess = value;
            }
        }
        public int HeatTransfer
        {
            get => heatTransfer;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    heatTransfer = value;
            }
        }
        public System.Double Frequency
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

        public override string ToString()
        {
            string result = "";
            result += $"Socket type: {SocketType} \n";
            result += "Overklocking: ";
            result += (Overklocking) ? "Yes\n" : "No\n";
            result += $"Cores: {Cores}\n";
            result += "Embedded GPU: ";
            result += (EmbeddedGPU) ? "Yes\n" : "No\n";
            result += $"Technical process: {TechnicalProcess}nm\n";
            result += $"Heat transfer: {HeatTransfer}W\n";
            result += $"Frequency: {Frequency}GHz\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.CPUs.FirstOrDefault(item => item.ID == this.ID);
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
