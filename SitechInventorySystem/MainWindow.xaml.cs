using SitechInventorySystem.Modules.Maintenance;
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

namespace SitechInventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            SetModule(new SupplierModule());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SetModule(UserControl u)
        {
            ModuleDockGrid.Children.Clear();
            u.Height = double.NaN;
            u.Width = double.NaN;
            u.Margin = new Thickness(0);
            ModuleDockGrid.Children.Add(u);
        }
    }
}
