using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    abstract class ComputerComponent
    {
        private int count;
        private float price;
        public int Count
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
        public float Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count");
                else
                    price = value;
            }
        }
        public string Brand { get; set;}
        public string Model { get; set; }
        public string AboutComponent { get; set; }
    };
}
