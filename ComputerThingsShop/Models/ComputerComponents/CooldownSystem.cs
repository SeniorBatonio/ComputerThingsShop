using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class CooldownSystem : ComputerComponent
    {
        private int diametr;
        private int rotationSpeed;
        private int noizeLevel;
        private int maxTDP;

        public string MainFunction { get; set; }
        public string Type { get; set; }
        public int Diametr
        {
            get => diametr;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    diametr = value;
            }
        }
        public int RotationSpeed
        {
            get => rotationSpeed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    rotationSpeed = value;
            }
        }
        public int NoiseLevel
        {
            get => noizeLevel;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    noizeLevel = value;
            }
        }
        public int MaxTDP
        {
            get => maxTDP;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    maxTDP = value;
            }
        }
        public string TypeOfBearing { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Main function: {MainFunction} \n";
            result += $"Type: {Type}\n";
            result += $"Diametr of fan: {Diametr}centimetr(s)\n";
            result += $"Rotation speed: {RotationSpeed}RPM\n";
            result += $"Noise level: {NoiseLevel}db\n";
            result += $"MaxTDP: {MaxTDP}W\n";
            result += $"Type of bearing: {TypeOfBearing}\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.CooldownSystems.FirstOrDefault(item => item.ID == this.ID);
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
