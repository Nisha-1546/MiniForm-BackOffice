

using System;
using System.Collections.Generic;
using System.Text;
using App.core.Utilities;
using App.core.Models;

namespace App.core.Contracts
{
    public interface IProductService
    {
       public Product Add(Product product);
        public bool Update(Product product);
        public bool Delete(String id);
        public Product GetById(String id);
        public List<Product> GetAll();
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status);
           




    }
}
