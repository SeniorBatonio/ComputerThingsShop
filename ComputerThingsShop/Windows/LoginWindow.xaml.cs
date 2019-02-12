using ComputerThingsShop.Models;
using ComputerThingsShop.Windows;
using System.Linq;
using System.Windows;

namespace ComputerThingsShop
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private RegisterWindow registerWindow = new RegisterWindow();
        public User User { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            this.LoginButton.Click += LoginButton_Click;
            this.RegisterButton.Click += RegisterButton_Click;
            this.ExitButton.Click += ExitButton_Click;
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                var users = context.Users;
                var user = users.FirstOrDefault(User => User.UserName == this.Username.Text);
                if (user != null)
                {
                    if (user.Password == this.UserPassword.Password)
                    {
                        this.User = user;
                        this.Close();
                    }
                    else { new ApplicationMessageBox().Show("Incorrect password!"); }
                }
                else { new ApplicationMessageBox().Show("Incorrect login!"); }
            }
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
    }
}
