using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    public abstract class ComputerComponent
    {
        private int count;
        private double price;
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
        public double Price
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
        public int ID { get; set; }
        public string Brand { get; set;}
        public string Model { get; set; }
        public string AboutComponent { get; set; }
    };
}
