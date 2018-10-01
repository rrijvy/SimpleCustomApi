using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCustomApi.Models;

namespace SimpleCustomApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;
        public ProductController(IProductServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult<Product> AddProduct(Product product)
        {
            var items = _services.AddProducts(product);

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }

        [HttpGet]
        [Route("Get")]
        public ActionResult<Dictionary<string, Product>> GetProduct()
        {
            var items = _services.GetProducts();

            if (items.Count == 0)
            {
                return NotFound();
            }

            return items;
        }
    }
}