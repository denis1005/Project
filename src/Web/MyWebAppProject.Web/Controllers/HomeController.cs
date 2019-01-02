namespace MyWebAppProject.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyWebAppProject.Data.Common.Repositories;
    using MyWebAppProject.Data.Models;
    using MyWebAppProject.Data.Repositories;
    using System.Linq;

    public class HomeController : BaseController
    {
       
         
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
           
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View();
    }
}
