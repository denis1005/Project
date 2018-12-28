using MyWebAppProject.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Data.Models
{
   public class Product : BaseModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CatrgoryId { get; set; }
        public Category Category { get; set; }

        public string Description { get; set; }

        public int OrderDetailesId { get; set; }
        public OrderDetailes OrderDetailes { get; set; }
    }
}
