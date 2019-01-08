using MyWebAppProject.Data.Common.Repositories;
using MyWebAppProject.Data.Models;
using MyWebAppProject.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebAppProject.Services.Data
{
    public class CategoriesServices : ICategories
    {
        private readonly IRepository<Category> categoriesRepository;

        public CategoriesServices(IRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public TViewModel GetCategoryByName<TViewModel>(string name)
        {
            var category = this.categoriesRepository.All().Where(x => x.Name == name)
                .To<TViewModel>().FirstOrDefault();
            return category;
        }
    }
}
