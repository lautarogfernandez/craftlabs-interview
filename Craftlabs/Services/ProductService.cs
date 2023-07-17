using Craftlabs.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Craftlabs.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository productRepository)
        {
            this._repository = productRepository;
        }

        public async Task<IEnumerable<ProductResponse>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(product => ProductResponse.FromDomain(product));
        }
    }
}