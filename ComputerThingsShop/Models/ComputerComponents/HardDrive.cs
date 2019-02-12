using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class HardDrive : ComputerComponent
    {
        private int capasity;
        private int writeSpeed;
        private int read;

        public string DriveType { get; set; }
        public int Capasity
        {
            get => capasity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    capasity = value;
            }
        }
        public int WriteSpeed
        {
            get => writeSpeed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    writeSpeed = value;
            }
        }
        public int ReadSpeed
        {
            get => read;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    read = value;
            }
        }
        public string Connection { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Drive type: {DriveType} \n";
            result += $"Capasity: {Capasity}Gb\n";
            result += $"WriteSpeed: {WriteSpeed}MbPS\n";
            result += $"ReadSpeed: {ReadSpeed}MbPS\n";
            result += $"Connection: {Connection}\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.HardDrives.FirstOrDefault(item => item.ID == this.ID);
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
