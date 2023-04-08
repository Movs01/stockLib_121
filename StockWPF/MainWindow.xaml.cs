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

namespace StockWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ManagerNavigator.MainFrame = MainFrame;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AllProduct_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigator.MainFrame.Navigate(new AllProductsPage());
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigator.MainFrame.Navigate(new OneProductPage());
        }
    }
}
