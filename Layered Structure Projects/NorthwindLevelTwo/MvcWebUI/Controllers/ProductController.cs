using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetAll()
            };
            return View(model);
        }

        
        public IActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.AddProduct(product);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Delete(int productId)
        {
            var model = new ProductListViewModel
            {
                Product = _productService.GetProduct(productId)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _productService.DeleteProduct(product);
            return RedirectToAction("Index","Product");
        }

        public IActionResult Update(int productId)
        {
            var model = new ProductListViewModel
            {
                Product = _productService.GetProduct(productId)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("Index", "Product");
        }


    }
}
