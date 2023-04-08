using stockLib_121;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLib_121
{
    public class Product
    {
        private static int Count;
        public int Id { get; }
        public string Name { get; set; }
        public string Article { get; set; }
        public int Price { get; set; }
        public UnitMeasure Unit { get; set; }
        public DateTime DateReceipt { get; set; }
        public double Margin { get; set; }
        public bool IsFrozen { get; set; }
        public string ImagePath { get; set; }
        public Product() 
        {
            Count++;
            Id = Count;
            Name = "Новый товар";
            Article = "XXX-000-00";
            Price = 0;
            Unit = UnitMeasure.штука;
            DateReceipt = DateTime.Today;
            Margin = 0;
            IsFrozen = false;
            ImagePath= "dafault.bmp";
        }

        public Product(string name, string article, int price, double margin):this()
        {
            this.Name = name;
            Article = article;
            Price = price;
            Margin= margin;
        }
    }
}
