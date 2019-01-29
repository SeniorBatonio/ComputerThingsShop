using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class Motherboard : ComputerComponent
    {
        int numberRAMsocket; //количество слотов под оперативную память
        int powerFromProcessor;

        public string BuildinSocket { get; set; }
        public string FormFactor { get; set; }
        public string Chipset { get; set; }
        public string TypeOfRAM { get; set; }
        int NumberRAMSocket
        {
            get => numberRAMsocket;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    numberRAMsocket = value;
            }
        }
        public string FrontPanelSocket { get; set; } // задняя панель с разёмами под USB, монитор и тд
        int PowerFromProcessor
        {
            get => powerFromProcessor;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    powerFromProcessor = value;
            }
        }
    }
}
