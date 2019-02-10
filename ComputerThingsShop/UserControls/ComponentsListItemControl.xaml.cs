using ComputerThingsShop.Models.ComputerComponents;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ComponentsListItemControl.xaml
    /// </summary>
    public partial class ComponentsListItemControl : UserControl
    {
        public static List<ComponentItemControl> ComputerCases = new List<ComponentItemControl>();
        public static List<ComponentItemControl> CooldownSystems = new List<ComponentItemControl>();
        public static List<ComponentItemControl> CPU = new List<ComponentItemControl>();
        public static List<ComponentItemControl> GPU = new List<ComponentItemControl>();
        public static List<ComponentItemControl> HardDrives = new List<ComponentItemControl>();
        public static List<ComponentItemControl> Motherboards = new List<ComponentItemControl>();
        public static List<ComponentItemControl> PowerSupplies = new List<ComponentItemControl>();
        public static List<ComponentItemControl> RAM = new List<ComponentItemControl>();

        public ComponentsListItemControl()
        {
            InitializeComponent();

            using (ApplicationContext context = new ApplicationContext("ComputerThingsDB"))
            {
                InitItemCollection(context.ComputerCases, ComputerCases);
                InitItemCollection(context.CooldownSystems, CooldownSystems);
                InitItemCollection(context.CPUs, CPU);
                InitItemCollection(context.GPUs, GPU);
                InitItemCollection(context.HardDrives, HardDrives);
                InitItemCollection(context.Motherboards, Motherboards);
                InitItemCollection(context.PowerSupplies, PowerSupplies);
                InitItemCollection(context.RAMs, RAM);
            }

            this.ListItems.Items.Clear();
        }

        private void InitItemCollection(IEnumerable<ComputerComponent> componentsList, List<ComponentItemControl> list)
        {
            foreach (var component in componentsList)
            {
                var item = new ComponentItemControl();
                item.Item = component;
                item.Brand.Text = component.Brand;
                item.Model.Text = component.Model;
                item.Price.Text = $"{component.Price}UAH";
                item.MouseLeftButtonDown += Item_MouseLeftButtonDown;
                list.Add(item);
            }
        }

        private void Item_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = (ComponentItemControl)sender;
            var componentInformation = new ComponentInformationControl();
            componentInformation.Brand.Content = item.Brand.Text;
            componentInformation.Brand.Content = item.Brand.Text;
        }
    }
}
