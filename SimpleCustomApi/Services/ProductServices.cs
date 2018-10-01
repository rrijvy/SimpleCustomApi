using SimpleCustomApi.Controllers;
using SimpleCustomApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCustomApi.Services
{
    public class ProductServices : IProductServices
    {
        private readonly Dictionary<string, Product> _products;

        public ProductServices()
        {
            _products = new Dictionary<string, Product>();
        }

        public Product AddProducts(Product product)
        {
            _products.Add(product.Name, product);

            return product;
        }

        public Dictionary<string, Product> GetProducts()
        {
            return _products;
        }
    }
}
