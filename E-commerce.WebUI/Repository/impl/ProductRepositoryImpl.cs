using E_commerce.WebUI.Models;
using System.Collections.Generic;

namespace E_commerce.WebUI.Repository.impl
{
    public class ProductRepositoryImpl : ProductRepository
    {
        private readonly List<Product> _products = DataClass.products;

        public void deleteProduct(int id)
        {

            _products.Remove(getProductById(id));
        }

        public List<Product> getAllProduct()
        {
            return _products;  
        }

        public Product getProductById(int id)
        {
           return _products.Find(item => item.Id == id);
        }

        public void saveProduct(Product product)
        {
            _products.Add(product); 
        }

        public void updateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
