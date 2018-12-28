using MyWebAppProject.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Data.Models
{
    public class OrderDetailes: BaseModel<int>

    {
        public OrderDetailes()
        {
            this.Products = new HashSet<Product>();
        }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int QuantityOrdered { get; set; }

        public Decimal TotalPrice { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
