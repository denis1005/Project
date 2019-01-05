﻿using MyWebAppProject.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWebAppProject.Data.Models
{
   public class Product : BaseModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

       

        public string Description { get; set; }

      

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public string ProductImage { get; set; }
    }
}
