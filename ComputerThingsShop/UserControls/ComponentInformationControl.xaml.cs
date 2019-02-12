using ComputerThingsShop.Models;
using ComputerThingsShop.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ComputerThingsShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ComponentInformationControl.xaml
    /// </summary>
    public partial class ComponentInformationControl : UserControl
    {
        ComponentItemControl ComponentItem { get; set; }

        public event DependencyPropertyChangedEventHandler CountChanged;

        public ComponentInformationControl(ComponentItemControl componentItem)
        {
            InitializeComponent();
            ComponentItem = componentItem;
            CountChanged += CheckCountChanged;
            this.BuyButton.Click += BuyButton_Click;
            CountChanged(this, new DependencyPropertyChangedEventArgs());
        }

        private void CheckCountChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(ComponentItem == null) { return; }
            if(ComponentItem.Item.Count <= 0)
            {
                this.BuyButton.Content = "Not available";
                this.BuyButton.Foreground = Brushes.Black;
                this.BuyButton.IsEnabled = false;
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            Basket.basket.Add(ComponentItem);
            ComponentItem.Item.Count -= 1;
            CountChanged(this, new DependencyPropertyChangedEventArgs());
            new ApplicationMessageBox().Show("Item added to basket");
        }


    }
}
