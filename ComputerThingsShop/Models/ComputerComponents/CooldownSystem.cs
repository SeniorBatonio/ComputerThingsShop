using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class CooldownSystem : ComputerComponent
    {
        private int diametr;
        private int rotationSpeed;
        private int noizeLevel;
        private int maxTDP;

        public string MainFunction { get; set; }
        public string Type { get; set; }
        public int Diametr
        {
            get => diametr;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    diametr = value;
            }
        }
        public int RotationSpeed
        {
            get => rotationSpeed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    rotationSpeed = value;
            }
        }
        public int NoiseLevel
        {
            get => noizeLevel;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    noizeLevel = value;
            }
        }
        public int MaxTDP
        {
            get => maxTDP;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    maxTDP = value;
            }
        }
        public string TypeOfBearing { get; set; }//тип 
    }
}
