using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenApp.Domain.Entities
{
    public class Product
    {
        //try nothing
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation properties
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
