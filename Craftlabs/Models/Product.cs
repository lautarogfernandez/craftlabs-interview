using System.Collections.Generic;

namespace Craftlabs.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}