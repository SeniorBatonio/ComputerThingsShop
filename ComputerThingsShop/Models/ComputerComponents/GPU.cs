using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class GPU : ComputerComponent
    {
        private int memoryCapasity;
        private int additionalNutrition;
        private int size;

        public int MemoryCapasity
        {
            get => memoryCapasity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    memoryCapasity = value;
            }
        }
        public string MemoryType { get; set; }
        public string InterfaceConnection { get; set; }
        public string CooldownSystem { get; set; }
        public int AdditionalNutrition
        {
            get => additionalNutrition;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    additionalNutrition = value;
            }
        }
        public int Size
        {
            get => size;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    size = value;
            }
        }


    }
}
