using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebAppProject.Data.Common.Repositories;
using MyWebAppProject.Data.Models;
using MyWebAppProject.Services.Data;
using MyWebAppProject.Web.ViewModels.Categories;
using MyWebAppProject.Web.ViewModels.Men;

namespace MyWebAppProject.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IRepository<Product> productRepository;
        

        public CategoriesController(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
            
        }
        public IActionResult Men(int id)
        {
            var productes = this.productRepository.All()
                .Where(x=>x.CategoryId==id)
                .Select(x => new MenViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    ProductImage = x.ProductImage
                });
            var viewModel = new IndexManViewModel
            {
                Productes = productes
            };
            return this.View(viewModel);
        }
        public IActionResult Women(int id)
        {
            var productes = this.productRepository.All()
                 .Where(x => x.CategoryId == id)
                 .Select(x => new MenViewModel
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Price = x.Price,
                     Description = x.Description,
                     ProductImage = x.ProductImage
                 });
            var viewModel = new IndexManViewModel
            {
                Productes = productes
            };
            return this.View(viewModel);
        }
    }
}