using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop.Models
{
    class Order
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPhoneNumber { get; set; }
        public string ComponentBrand { get; set; }
        public string ComponentModel { get; set; }
        public double ComponentPrice { get; set; }
    }
}
