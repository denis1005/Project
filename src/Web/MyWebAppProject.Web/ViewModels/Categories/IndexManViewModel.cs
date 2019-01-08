using MyWebAppProject.Web.ViewModels.Men;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppProject.Web.ViewModels.Categories
{
    public class IndexManViewModel
    {
        public IEnumerable<MenViewModel> Productes { get; set; }
    }
}
