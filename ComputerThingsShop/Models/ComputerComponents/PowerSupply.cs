using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string NutritionCPU { get; set; }// питание
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
    }
}
