using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Задание__Wpf14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Батон",
                ProdPrice = 30,
                ProdImage = "Data/Bread.jpeg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Мясо",
                ProdPrice = 100,
                ProdImage = "Data/Meat.jpeg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 80,
                ProdImage = "Data/Apples.jpeg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Смартфон",
                ProdPrice = 60000,
                ProdImage = "Data/Phone.jpeg",
                ProductCategory = ProductCategories.Technics
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 3000,
                ProdImage = "Data/Iron.jpeg",
                ProductCategory = ProductCategories.Technics
            });
            products.Add(new Product()
            {
                ProdName = "Холодильник",
                ProdPrice = 30000,
                ProdImage = "Data/Refrigerator.jpeg",
                ProductCategory = ProductCategories.Technics
            });
            listBox.ItemsSource = products;
        }
    }
}
