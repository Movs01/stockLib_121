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
using stockLib_121;
using StockLib_121;

namespace StockWPF
{
    /// <summary>
    /// Логика взаимодействия для AllProductsPage.xaml
    /// </summary>
    public partial class AllProductsPage : Page
    {
        public AllProductsPage()
        {           
            InitializeComponent();
            GridAlProducs.ItemsSource = ManagerModel.stock;
        }
    }
}
