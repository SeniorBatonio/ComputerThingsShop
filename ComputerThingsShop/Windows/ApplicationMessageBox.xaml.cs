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
using System.Windows.Shapes;

namespace ComputerThingsShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для ApplicationMessageBox.xaml
    /// </summary>
    public partial class ApplicationMessageBox : Window
    {
        public ApplicationMessageBox()
        {
            InitializeComponent();
            this.OkButton.Click += (object sender, RoutedEventArgs e) => this.Close();
        }

        public void Show(string message)
        {
            this.Message.Text = message;
            base.Show();
        }
    }
}
