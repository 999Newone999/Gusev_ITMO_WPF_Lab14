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
using System.Globalization;

namespace Gusev_ITMO_WPF_Lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName="Хлеб Бородинский",
                ProductPrice=50.00,
                ProductPicture ="Бородинский.jpg",
                ProductCategory = ProductCategories.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                ProductPrice = 20000.00,
                ProductPicture = "Телик.jpg",
                ProductCategory = ProductCategories.Бытовая_техника
            });


            lstBox.ItemsSource = products;
        }
    }

    /*class ProductCatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == 1)
            {
                return "Data/Еда.jpg";
            }
            return "Data/Техника.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }

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
    }*/
}
