using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class RAM : ComputerComponent
    {
        private int latency;
        private int memoryCapasity;
        private int frequency;

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
        public string Type { get; set; }
        public bool PassiveCooling { get; set; }
        public int Frequency
        {
            get => frequency;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    frequency = value;
            }
        }
        public bool Overclocking { get; set; }
        public int Latency
        {
            get => latency;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    latency = value;
            }
        }
    }
}
