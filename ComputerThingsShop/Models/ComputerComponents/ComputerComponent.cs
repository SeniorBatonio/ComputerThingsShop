using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    abstract class ComputerComponent
    {
        private static int count = 0;
        public static int Count
        {
            get => count;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    count = value;
            }
        }
        protected float Price { get; }
        protected string brand;
        protected string model;

        public ComputerComponent(float price, string brand, string model)
        {
            this.Price = price;
            this.brand = brand;
            this.model = model;
            this.Price++;
        }
    };
}
