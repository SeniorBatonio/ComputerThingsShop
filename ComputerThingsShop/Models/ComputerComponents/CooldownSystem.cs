using ComputerThingsShop.Models.ComputerComponentsParams;
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
        public CooldownSystem(CooldownSystemParams @params) : base(@params.price, @params.brand, @params.model)
        {
            this.mainFunction = @params.mainFunction;
            this.type = @params.type;
            this.diametr = @params.diametr;
            this.rotationSpeed = @params.rotationSpeed;
            this.noiseLevel = @params.noiseLevel;
            this.maxTDP = @params.maxTDP;
            this.typeOfBearing = @params.typeOfBearing;
        }
    }
}
