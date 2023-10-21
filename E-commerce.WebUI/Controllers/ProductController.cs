using E_commerce.WebUI.Models;
using E_commerce.WebUI.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace E_commerce.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.getAllProduct();
            return View(products);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
