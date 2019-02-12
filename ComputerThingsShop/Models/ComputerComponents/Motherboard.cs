using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class Motherboard : ComputerComponent
    {
        int numberRAMsocket; //количество слотов под оперативную память
        int powerFromProcessor;

        public string BuildinSocket { get; set; }
        public string FormFactor { get; set; }
        public string Chipset { get; set; }
        public string TypeOfRAM { get; set; }
        public int NumberRAMSocket
        {
            get => numberRAMsocket;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    numberRAMsocket = value;
            }
        }
        public string FrontPanelSocket { get; set; } // задняя панель с разёмами под USB, монитор и тд
        public int PowerFromProcessor
        {
            get => powerFromProcessor;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    powerFromProcessor = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            result += $"Buildin socket: {BuildinSocket} \n";
            result += $"Form factor: {FormFactor}\n";
            result += $"Chipset: {Chipset}\n";
            result += $"Type of RAM: {TypeOfRAM}\n";
            result += $"Count of RAM sockets: {NumberRAMSocket}\n";
            result += $"Front panel socket: {FrontPanelSocket}\n";
            result += $"Power from processor: {PowerFromProcessor}pin\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.Motherboards.FirstOrDefault(item => item.ID == this.ID);
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
