

using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using App.core.Contracts;

namespace App.core.Services
{
    public class InMemoryProductService : IProductService

    {
        private List<Product> _products;
        public InMemoryProductService() {

        _products = new List<Product>();
            GenerateFakeProducts();

        }

        public Product Add(Product product) {
            throw new NotImplementedException();
        }
        public bool Update(Product product) { 
            return false;
        }
        public bool Delete(String id) {
        return true;
        }
        public Product GetById(String id) {
            throw new NotImplementedException();
        }
        public List<Product> GetAll() { 
            return _products.OrderBy(p=>p.Name).ToList();
        
        }
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status) {
            throw new NotImplementedException();
        }
private void GenerateFakeProducts()
        {
            _products.Clear();

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name ="Laptop",
                Category=ProductCategoryEnum.Electronics,
                Price=15000.0m,
                Stock=10,
                Status=ProductStatusEnum.Active
            });
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "USB-C Cable",
                Category = ProductCategoryEnum.Electronics,
                Price = 1200,
                Stock = 18,
                Status = ProductStatusEnum.Active
            });
        }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

    }
}
