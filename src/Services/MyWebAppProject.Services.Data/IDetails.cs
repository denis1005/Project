using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Services.Data
{
   public interface IDetails
    {
        TViewModel GetProductById<TViewModel>(int id);
    }
}
