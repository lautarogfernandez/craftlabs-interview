using Craftlabs.Models;
using Craftlabs.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Craftlabs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResponse>> GetAll()
        {
            return await _productService.GetAllAsync();
        }
    }
}