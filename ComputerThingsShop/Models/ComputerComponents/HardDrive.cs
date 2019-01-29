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
        public int Read
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
    }
}
