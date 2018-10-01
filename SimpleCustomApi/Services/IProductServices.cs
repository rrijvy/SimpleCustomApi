using SimpleCustomApi.Models;
using System.Collections.Generic;

namespace SimpleCustomApi.Controllers
{
    public interface IProductServices
    {
        Product AddProducts(Product product);
        Dictionary<string, Product> GetProducts();
    }
}