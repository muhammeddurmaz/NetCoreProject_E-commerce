using E_commerce.WebUI.Models;
using System.Collections.Generic;

namespace E_commerce.WebUI.Repository
{
    public interface ProductRepository
    {
        Product getProductById(int id);
        List<Product> getAllProduct();
        void saveProduct(Product product);
        void deleteProduct(int id);
        void updateProduct(Product product);    

    }
}
