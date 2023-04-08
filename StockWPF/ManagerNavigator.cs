using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StockWPF
{
    public static class ManagerNavigator
    {
        public static Frame MainFrame { get; set; }
        static ManagerNavigator()
        {
            MainFrame = new Frame();
        }

    }
}
