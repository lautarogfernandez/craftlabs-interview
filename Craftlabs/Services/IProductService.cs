using Craftlabs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Craftlabs.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductResponse>> GetAllAsync();
    }
}