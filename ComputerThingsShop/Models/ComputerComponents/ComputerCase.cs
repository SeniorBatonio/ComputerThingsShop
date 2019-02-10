using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
