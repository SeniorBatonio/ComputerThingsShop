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
        public BasketControl()
        {
            InitializeComponent();
            this.ListItems.Items.Clear();
            this.ListItems.ItemsSource = Basket.basket;
            this.BuyButton.Click += BuyButton_Click;
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            this.ListItems.ItemsSource = null;
            new ApplicationMessageBox().Show("The order is accepted");
        }
    }
}
