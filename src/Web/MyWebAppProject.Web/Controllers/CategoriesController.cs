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
        private readonly ICategories categoriesService;

        public CategoriesController(IRepository<Product> productRepository,
            IRepository<Category> categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoriesService= categoriesService;
        }
        public IActionResult Men(string name)
        {
            return View();

        }
        public IActionResult Women()
        {
            return View();
        }
    }
}