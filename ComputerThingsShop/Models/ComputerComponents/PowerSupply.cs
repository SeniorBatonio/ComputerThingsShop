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

        public string NutritionCPU { get; set; }// питание
        public string CooldownSystem { get; set; }
        public string NutritionGPU { get; set; }
        public string Formfactor { get; set; }
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
        public bool Modular{ get; set; }

    }
}
