using System;
using System.Linq;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class PowerSupply : ComputerComponent
    {
        private int power;

        public int Power
        {
            get => power;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    power = value;
            }
        }
        public string NutritionCPU { get; set; }
        public string CooldownSystem { get; set; }
        public string NutritionGPU { get; set; }
        public string FormFactor { get; set; }
        public bool Modular{ get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Power: {Power}W \n";
            result += $"Nutrition CPU: {NutritionCPU}\n";
            result += $"Cooldown system: {CooldownSystem}\n";
            result += $"Nutrition GPU: {NutritionGPU}\n";
            result += $"Form factor: {FormFactor}\n";
            result += "Modular: ";
            result += (Modular) ? "Yes\n" : "No\n";
            return result;
        }

        public override void Buy()
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var boughtItem = context.PowerSupplies.FirstOrDefault(item => item.ID == this.ID);
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
