using StockLib_121;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockLib_121
{
    public static class ManagerModel
    {
        public static Stock stock { get; set; }

        static ManagerModel()
        {
            stock = new Stock();
            stock.Add(new Product());
            stock.Add(new Product("Новый новый товар", "888-555-7", 345, 567.9));
        }
    }
}
