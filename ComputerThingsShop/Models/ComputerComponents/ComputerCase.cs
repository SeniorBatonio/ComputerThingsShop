using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    class ComputerCase : ComputerComponent
    {
        string formFacktor;
        string typeOfMotherboard;
        string materials;
        int numberOfFans;
        bool powerSupply;//есть или не установлен по умолчанию

        public ComputerCase(float price, string brand, string model, string formFacktor, string typeOfMotherboard,
        string materials, int numberOfFans, bool powerSupply) : base(price, brand, model)
        {
            this.formFacktor = formFacktor;
            this.typeOfMotherboard = typeOfMotherboard;
            this.materials = materials;
            this.numberOfFans = numberOfFans;
            this.powerSupply = powerSupply;
        }
    }
}
