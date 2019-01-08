using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Services.Data
{
   public interface ICategories
    {
        TViewModel GetCategoryByName<TViewModel>(string name);
    }
}
