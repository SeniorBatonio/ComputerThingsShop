using System;

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
        public int NumberRAMSocket
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
        public int PowerFromProcessor
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

        public override string ToString()
        {
            string result = "";
            result += $"Buildin socket: {BuildinSocket} \n";
            result += $"Form factor: {FormFactor}\n";
            result += $"Chipset: {Chipset}\n";
            result += $"Type of RAM: {TypeOfRAM}\n";
            result += $"Count of RAM sockets: {NumberRAMSocket}\n";
            result += $"Front panel socket: {FrontPanelSocket}\n";
            result += $"Power from processor: {PowerFromProcessor}pin\n";
            return result;
        }
    }
}
