﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models.ComputerComponents
{
    abstract class ComputerComponent
    {
        private static int count = 0;
        private float price;
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

    };
}
