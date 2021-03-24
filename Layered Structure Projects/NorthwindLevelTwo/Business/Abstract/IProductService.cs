using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        Product GetProduct(int productId);
        void AddProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
    }
}
