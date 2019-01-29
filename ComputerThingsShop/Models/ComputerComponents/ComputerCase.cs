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
        public string FormFacktor { get; set; }
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
    }
}
