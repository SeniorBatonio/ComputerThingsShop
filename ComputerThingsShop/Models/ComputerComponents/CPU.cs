using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class CPU : ComputerComponent
    {
        private int cores;
        private int technicalProcess;
        private int heatTransfer;
        private float frequency;

        public string SocketType { get; set; }
        public bool Overklocking { get; set; }
        public int Cores
        {
            get => cores;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    cores = value;
            }
        }
        public bool EmbeddedGPU { get; set; }
        public int TechnicalProcess
        {
            get => technicalProcess;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    technicalProcess = value;
            }
        }
        public int HeatTransfer
        {
            get => heatTransfer;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    heatTransfer = value;
            }
        }
        public float Frequency
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

    }
}
