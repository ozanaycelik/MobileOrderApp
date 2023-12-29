using MobileOrderApp.BackendSources.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOrderApp.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(); // PropertyChanged olayını tetikle
            }
        }

        public ProductViewModel()
        {
            LoadProducts(); // Ürünleri yükleme metodu
        }

        public void LoadProducts()
        {
            // Ürünleri ekleyin (örnek olarak)
            Products = new ObservableCollection<Product>
        {
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 1", Price = 19.99, ImageSource = "damacana1.png", Quantity = 0 },
            new Product { Name = "Ürün 2", Price = 24.99, ImageSource = "damacana1.png", Quantity = 0 },
            // Diğer ürünleri ekleyin
        };
        }
    }
}
