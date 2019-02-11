using System;

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

        public override string ToString()
        {
            string result = "";
            result += $"Memory capasity: {MemoryCapasity}Gb \n";
            result += $"Memory type: {MemoryType}\n";
            result += $"Interface connection: {InterfaceConnection}\n";
            result += $"Cooldown system: {CooldownSystem}\n";
            result += "Additional nutrition: ";
            result += (AdditionalNutrition > 0) ? $"{AdditionalNutrition}pin\n" : "No\n";
            result += $"Size: {Size}mm\n";
            return result;
        }
    }
}
