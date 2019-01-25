using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class CooldownSystem : ComputerComponent
    {
        private	string mainFunction;
        private string type;
        private int diametr;
        private int rotationSpeed;
        private int noiseLevel;
        private int maxTDP;
        private string typeOfBearing;//тип 
        public CooldownSystem(float price, string brand, string model, string mainFunction, string type, int diametr,
        int rotationSpeed, int noiseLevel, int maxTDP, string typeOfBearing) : base(price, brand, model)
        {
            this.mainFunction = mainFunction;
            this.type = type;
            this.diametr = diametr;
            this.rotationSpeed = rotationSpeed;
            this.noiseLevel = noiseLevel;
            this.maxTDP = maxTDP;
            this.typeOfBearing = typeOfBearing;
        }
    }
}
