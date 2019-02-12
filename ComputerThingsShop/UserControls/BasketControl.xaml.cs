using ComputerThingsShop.Models;
using ComputerThingsShop.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerThingsShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для BasketControl.xaml
    /// </summary>
    public partial class BasketControl : UserControl
    {
        private double price = 0;

        public BasketControl()
        {
            InitializeComponent();
            this.ListItems.Items.Clear();
            this.ListItems.Items.IsLiveFiltering = false;
            this.ListItems.ItemsSource = Basket.basket;
            this.BuyButton.Click += BuyButton_Click;
            var items = (List<ComponentItemControl>)this.ListItems.ItemsSource;
            foreach (var item in items)
            {
                price += item.Item.Price;
            }
            this.PriceBlock.Text = $"Price: {price}UAH";
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            Basket.Buy();
            this.ListItems.ItemsSource = null;
            price = 0;
            new ApplicationMessageBox().Show("The order is accepted");
        }
    }
}
