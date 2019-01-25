using ComputerThingsShop.Models.ComputerComponentsParams;
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

        public ComputerCase(ComputerCaseParams @params) : base(@params.price, @params.brand, @params.model)
        {
            this.formFacktor = @params.formFacktor;
            this.typeOfMotherboard = @params.typeOfMotherboard;
            this.materials = @params.materials;
            this.numberOfFans = @params.numberOfFans;
            this.powerSupply = @params.powerSupply;
        }
    }
}
