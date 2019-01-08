using MyWebAppProject.Data.Common.Repositories;
using MyWebAppProject.Data.Models;
using MyWebAppProject.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebAppProject.Services.Data
{
    public class DetailsServices : IDetails
    {
        private readonly IRepository<Product> producRepository;

        public DetailsServices(IRepository<Product> producRepository)
        {
            this.producRepository = producRepository;
        }
        public TViewModel GetProductById<TViewModel>(int id)
        {
            var product = this.producRepository.All().Where(x => x.Id == id)
                .To<TViewModel>().FirstOrDefault();
            return product;
        }
    }
}
