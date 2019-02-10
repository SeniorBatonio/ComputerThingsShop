using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class HardDrive : ComputerComponent
    {
        private int capasity;
        private int writeSpeed;
        private int read;

        public string DriveType { get; set; }
        public int Capasity
        {
            get => capasity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    capasity = value;
            }
        }
        public int WriteSpeed
        {
            get => writeSpeed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    writeSpeed = value;
            }
        }
        public int ReadSpeed
        {
            get => read;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    read = value;
            }
        }
        public string Connection { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Drive type: {DriveType} \n";
            result += $"Capasity: {Capasity}Gb\n";
            result += $"WriteSpeed: {WriteSpeed}MbPS\n";
            result += $"ReadSpeed: {ReadSpeed}MbPS\n";
            result += $"Connection: {Connection}\n";
            return result;
        }
    }
}
