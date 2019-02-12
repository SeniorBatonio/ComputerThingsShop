using ComputerThingsShop.Models;
using ComputerThingsShop.Windows;
using System.Windows;
using System.Windows.Controls;

namespace ComputerThingsShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ComponentInformationControl.xaml
    /// </summary>
    public partial class ComponentInformationControl : UserControl
    {
        ComponentItemControl ComponentItem { get; set; }

        public ComponentInformationControl(ComponentItemControl componentItem)
        {
            InitializeComponent();
            ComponentItem = componentItem;
            this.BuyButton.Click += BuyButton_Click;
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            Basket.basket.Add(ComponentItem);
            new ApplicationMessageBox().Show("Item added to basket");
        }
    }
}
