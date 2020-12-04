using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing

{
    public interface IProductRepository
    {
        public IEnumerable<product> GetAllProducts();
        public product GetProduct(int id);
        public void UpdateProduct(product product);
        public void InsertProduct(product productToInsert);
        public IEnumerable<Category> GetCategories();
        public product AssignCategory();
        public void DeleteProduct(product product);
    }
}
