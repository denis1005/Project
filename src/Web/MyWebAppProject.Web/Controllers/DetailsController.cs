using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebAppProject.Services.Data;
using MyWebAppProject.Web.ViewModels.Details;

namespace MyWebAppProject.Web.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IDetails detailService;

        public DetailsController(IDetails detailService)
        {
            this.detailService = detailService;
        }

        public IActionResult Details(int id)
        {
            var product = this.detailService.GetProductById<DetailsViewModel>(id);
            return this.View(product);
            
        }
    }
}