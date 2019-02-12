using ComputerThingsShop.UserControls;
using System.Collections.Generic;

namespace ComputerThingsShop.Models
{
    class Basket
    {
        public static List<ComponentItemControl> basket = new List<ComponentItemControl>();

        public static void Buy()
        {
            foreach(var item in basket)
            {
                item.Item.Buy();
            }
        }
    }
}
