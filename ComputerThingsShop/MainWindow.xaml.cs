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
        LoginWindow LoginWindow = new LoginWindow();
        public MainWindow()
        {
            LoginWindow.LoginButton.Click += LoginButton_Click;
            LoginWindow.RegisterButton.Click += RegisterButton_Click;
            LoginWindow.ExitButton.Click += ExitButton_Click;
            LoginWindow.ShowDialog();
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var Users = context.Users;
                var User = Users.FirstOrDefault(user => user.UserName == LoginWindow.Username.Text);
                if (User != null)
                {
                    if (User.Password == LoginWindow.UserPassword.Password)
                    {
                        LoginWindow.Close();
                    }
                    else { MessageBox.Show("Incorrect password!"); }
                }
                else { MessageBox.Show("Incorrect login!"); }
            }
        }
    }
}
