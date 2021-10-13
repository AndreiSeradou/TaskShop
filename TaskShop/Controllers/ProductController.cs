using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Interfaces;
using TaskShop.Data.Models;

namespace TaskShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IShop _shop;
        private readonly IProduct _product;
        public ProductController(IShop shop, IProduct product)
        {
            _product = product;
            _shop = shop;

        }

        public async Task<IActionResult> EditingProduct(Product product)
        {
            await _product.DeleteProductAsync(product.Id);
            await _product.AddProductAsync(new Product { Name = product.Name, Description = product.Description, ShopId = product.ShopId });
            return View();
        }
        public async  Task<IActionResult> AddProduct(Product product)
        {
            await _product.AddProductAsync(new Product { Name = product.Name, Description = product.Description, ShopId = product.ShopId });
            return View();
        }

        public ViewResult ProductList(int id)
        {
            
            ViewBag.Shop = "Список продуктов";
            return View(_product.GetProductByShopAsync(id).Result);
        }

        public async Task<ViewResult> DeleteProduct(int id)
        {
            await _product.DeleteProductAsync(id);
            return View(id);
        }
    }
}
