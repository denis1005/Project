using MyWebAppProject.Data.Models;
using MyWebAppProject.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppProject.Web.ViewModels.Details
{
    public class DetailsViewModel: IMapFrom<Product>

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }



        public string Description { get; set; }


        public string ProductImage { get; set; }
    }
}
