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
    /// Логика взаимодействия для AccountControl.xaml
    /// </summary>
    public partial class AccountControl : UserControl
    {
        public AccountControl()
        {
            InitializeComponent();
            this.UserInitials.Content = MainWindow.User.GetInitials();
            this.Username.Text = MainWindow.User.UserName;
            this.Name.Text = MainWindow.User.Name;
            this.Surname.Text = MainWindow.User.Surname;
            this.PhoneNumber.Text = MainWindow.User.PhoneNumber;
            this.Password.Password = MainWindow.User.Password;

            this.Username.IsEnabled = false;
            this.Name.IsEnabled = false;
            this.Surname.IsEnabled = false;
            this.PhoneNumber.IsEnabled = false;
            this.Password.IsEnabled = false;

            this.EditButton.Click += EditButton_Click;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.EditButton.Click -= EditButton_Click;
            this.EditButton.Click += SaveChanges;
            this.EditButton.Content = "Save";
            this.Username.IsEnabled = true;
            this.Name.IsEnabled = true;
            this.Surname.IsEnabled = true;
            this.PhoneNumber.IsEnabled = true;
            this.Password.IsEnabled = true;
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            this.EditButton.Click -= SaveChanges;
            this.EditButton.Click += EditButton_Click;
            this.EditButton.Content = "Edit";
            this.Username.IsEnabled = false;
            this.Name.IsEnabled = false;
            this.Surname.IsEnabled = false;
            this.PhoneNumber.IsEnabled = false;
            this.Password.IsEnabled = false;
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var users = context.Users;
                var user = users.FirstOrDefault(User => User.ID == MainWindow.User.ID);
                user.UserName = this.Username.Text;
                user.Name = this.Name.Text;
                user.Surname = this.Surname.Text;
                user.PhoneNumber = this.PhoneNumber.Text;
                user.Password = this.Password.Password;
                context.SaveChanges();
            }
        }
    }
}
