using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class ComputerCase : ComputerComponent
    {
        private int numberOfFans;
        public string FormFactor { get; set; }
        public string TypeOfMotherboard { get; set; }
        public string Materials { get; set; }
        public int NumberOfFans
        {
            get => numberOfFans;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    numberOfFans = value;
            }
        }
        public bool PowerSupply { get; set; }//есть или не установлен по умолчанию

        public override string ToString()
        {
            string result = "";
            result += $"Number of fans: {numberOfFans} \n";
            result += $"Form factor: {FormFactor}\n";
            result += $"Type of motherboard: {TypeOfMotherboard}\n";
            result += $"Materials: {Materials}\n";
            result += $"Number of fans: {NumberOfFans}\n";
            result += "Power supply: ";
            result += (this.PowerSupply)? "In stock\n" : "Not in stock\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.ComputerCases.FirstOrDefault(item => item.ID == this.ID);
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
