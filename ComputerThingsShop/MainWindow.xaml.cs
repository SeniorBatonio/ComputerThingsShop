using ComputerThingsShop.Models;
using ComputerThingsShop.UserControls;
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

namespace ComputerThingsShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginWindow loginWindow = new LoginWindow();
        RegisterWindow registerWindow = new RegisterWindow();
        private ComponentsListItemControl itemsListControl = new ComponentsListItemControl();

        public MainWindow()
        {
            loginWindow.LoginButton.Click += LoginButton_Click;
            loginWindow.RegisterButton.Click += RegisterButton_Click;
            loginWindow.ExitButton.Click += ExitButton_Click;
            //loginWindow.ShowDialog();
            InitializeComponent();

            this.ActiveField.Content = itemsListControl;
            this.itemsListControl.ListItems.SelectionChanged += ListItems_SelectionChanged;

            this.ComputerCasesButton.Selected += (object sender, RoutedEventArgs e) =>
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.ComputerCases;

            this.CooldownSystemsButton.Selected += (object sender, RoutedEventArgs e) =>
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.CooldownSystems;

            this.CPUButton.Selected += (object sender, RoutedEventArgs e) =>
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.CPU;

            this.GPUButton.Selected += (object sender, RoutedEventArgs e) => 
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.GPU;

            this.HardDrivesButton.Selected += (object sender, RoutedEventArgs e) => 
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.HardDrives;

            this.MotherboardsButton.Selected += (object sender, RoutedEventArgs e) => 
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.Motherboards;

            this.PowerSuppliesButton.Selected += (object sender, RoutedEventArgs e) => 
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.PowerSupplies;

            this.RAMButton.Selected += (object sender, RoutedEventArgs e) => 
                this.itemsListControl.ListItems.ItemsSource = ComponentsListItemControl.RAM;

        }

        private void ListItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var componentInformation = new ComponentInformationControl();
            var curItem = (ComponentItemControl)this.itemsListControl.ListItems.SelectedItem;
            if (curItem != null)
            {
                componentInformation.BackButton.Click += (object sender1, RoutedEventArgs e1) => this.ActiveField.Content = itemsListControl;
                componentInformation.Brand.Content = curItem.Brand.Text;
                componentInformation.Model.Content = curItem.Model.Text;
                componentInformation.Price.Content = curItem.Price.Text;
                componentInformation.Characteristics.Text = curItem.Item.ToString();
                this.ActiveField.Content = componentInformation;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            registerWindow.RegisterButton.Click += Registration;
            registerWindow.CancelButton.Click += (object sender1, RoutedEventArgs e1) => registerWindow.Close();
            registerWindow.ShowDialog();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                context.Users.Add(new User()
                {
                    UserName = registerWindow.Username.Text,
                    Password = registerWindow.UserPassword.Password,
                    Name = registerWindow.Name.Text,
                    Surname = registerWindow.Surname.Text,
                    PhoneNumber = registerWindow.PhoneNumber.Text
                });
                context.SaveChanges();
            }
            registerWindow.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var Users = context.Users;
                var User = Users.FirstOrDefault(user => user.UserName == loginWindow.Username.Text);
                if (User != null)
                {
                    if (User.Password == loginWindow.UserPassword.Password)
                    {
                        loginWindow.Close();
                    }
                    else { MessageBox.Show("Incorrect password!"); }
                }
                else { MessageBox.Show("Incorrect login!"); }
            }
        }
    }
}
