namespace MyWebAppProject.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyWebAppProject.Data.Common.Repositories;
    using MyWebAppProject.Data.Models;
    using MyWebAppProject.Data.Repositories;
    using MyWebAppProject.Web.ViewModels.Home;
    using System;
    using System.Linq;

    public class HomeController : BaseController
    {
        private readonly IRepository<Product> productRepository;

        public HomeController(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var productes = this.productRepository.All()
                .OrderBy(x=>Guid.NewGuid())
                .Select(x => new IndexProductViewModel
                {
                    Id=x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    ProductImage = x.ProductImage
                });
            var viewModel = new IndexViewModel
            {
                Productes = productes
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
           
            return this.View();
        }

        public IActionResult Men()
        {

            return this.View();
        }

        public IActionResult Women()
        {

            return this.View();
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View();
    }
}
