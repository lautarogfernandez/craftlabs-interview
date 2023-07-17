using Craftlabs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Craftlabs.Services
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository() { }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            var product1 = new Product { Id = 1, Description = "tornillos tamaño x", Name = "tornillos", Stock = 20 };
            var product2 = new Product { Id = 2, Description = "herramienta 1 tamaño x", Name = "herramienta 1", Stock = 10 };
            var product3 = new Product { Id = 33, Description = "herramienta 2 tamaño y", Name = "herramienta 2", Stock = 7 };
            var list = new List<Product> { product1, product2, product3 };
            return Task.FromResult((IEnumerable<Product>)list);
        }
    }
}