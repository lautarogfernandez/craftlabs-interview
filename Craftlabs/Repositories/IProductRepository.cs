using Craftlabs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Craftlabs.Services
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}