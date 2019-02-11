using ComputerThingsShop.Models;
using ComputerThingsShop.UserControls;
using System.Windows;
using System.Windows.Controls;


namespace ComputerThingsShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginWindow loginWindow = new LoginWindow();
        private ComponentsListItemControl itemsListControl = new ComponentsListItemControl();

        public MainWindow()
        {
            //loginWindow.ShowDialog();
            InitializeComponent();

            this.ComputerCasesButton.Selected += ListItemSelectionChanged;
            this.CooldownSystemsButton.Selected += ListItemSelectionChanged;
            this.CPUButton.Selected += ListItemSelectionChanged;
            this.GPUButton.Selected += ListItemSelectionChanged;
            this.HardDrivesButton.Selected += ListItemSelectionChanged;
            this.MotherboardsButton.Selected += ListItemSelectionChanged;
            this.PowerSuppliesButton.Selected += ListItemSelectionChanged;
            this.RAMButton.Selected += ListItemSelectionChanged;

            this.itemsListControl.ListItems.SelectionChanged += ItemSelectionChanged;
        }

        private void ListItemSelectionChanged(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;
            var itemsType = item.Header;
            itemsListControl.Header.Content = itemsType;
            switch(itemsType)
            {
                case "Computer Cases":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.ComputerCases;
                    break;
                case "Cooldown Systems":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.CooldownSystems;
                    break;
                case "CPU":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.CPU;
                    break;
                case "GPU":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.GPU;
                    break;
                case "Hard Drives":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.HardDrives;
                    break;
                case "Motherboards":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.Motherboards;
                    break;
                case "Power Supplies":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.PowerSupplies;
                    break;
                case "RAM":
                    this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.RAM;
                    break;
            }
            this.ActiveField.Content = itemsListControl;
        }

        private void ItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var componentInformation = new ComponentInformationControl();
            var curItem = (ComponentItemControl)this.itemsListControl.ListItems.SelectedItem;
            if (curItem != null)
            {
                componentInformation.BackButton.Click += (object sender1, RoutedEventArgs e1) => this.ActiveField.Content = itemsListControl;
                componentInformation.ComponentPhoto.Source = curItem.ComponentPhoto.Source;
                componentInformation.Brand.Content = curItem.Brand.Text;
                componentInformation.Model.Content = curItem.Model.Text;
                componentInformation.Price.Content = curItem.Price.Text;
                componentInformation.Characteristics.Text = curItem.Item.ToString();
                this.ActiveField.Content = componentInformation;
            }
        }
    }
}
