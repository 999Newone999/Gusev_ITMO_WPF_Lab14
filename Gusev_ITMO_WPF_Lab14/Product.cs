using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gusev_ITMO_WPF_Lab14
{
        public enum ProductCategories
        {
            Еда,
            Бытовая_техника
        }

        public class Product
        {
            public string ProductName { get; set; }
            public double ProductPrice { get; set; }
            public string ProductPicture { get; set; }
            public ProductCategories ProductCategory { get; set; }
        }
}
