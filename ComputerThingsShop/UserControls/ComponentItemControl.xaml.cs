using ComputerThingsShop.Models.ComputerComponents;
using System.Windows.Controls;

namespace ComputerThingsShop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ComponentItemControl.xaml
    /// </summary>
    public partial class ComponentItemControl : UserControl
    {
        public ComputerComponent Item { get; set; }

        public ComponentItemControl()
        {
            InitializeComponent();
        }
    }
}
