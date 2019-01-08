using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppProject.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexProductViewModel> Productes { get; set; }
    }
}
