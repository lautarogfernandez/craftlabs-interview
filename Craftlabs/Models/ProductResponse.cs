namespace Craftlabs.Models
{
    public class ProductResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public static ProductResponse FromDomain(Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Stock = product.Stock
            };
        }
    }
}