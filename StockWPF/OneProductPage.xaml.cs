using stockLib_121;
using StockLib_121;
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
    /// Логика взаимодействия для OneProductPage.xaml
    /// </summary>
    public partial class OneProductPage : Page
    {
        Product currentProduct { get; set; }
        public OneProductPage()
        {
            InitializeComponent();
            currentProduct = new Product();
            DataContext = currentProduct;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ManagerModel.stock.Add(currentProduct);
            ManagerNavigator.MainFrame.Navigate( new AllProductsPage());
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigator.MainFrame.Navigate(new AllProductsPage());
        }
    }
}
