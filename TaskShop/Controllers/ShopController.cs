using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Interfaces;
using TaskShop.Data.Models;

namespace TaskShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShop _shop;
        private readonly IProduct _product;
        public  ShopController(IShop shop, IProduct product)
        {
            _product = product;
            _shop = shop;
           
        }

        private async Task CreateData()
        {
            
            await _shop.AddShopAsync(new Shop { Name = "MyShop", Address = "heryzo", OperatingMode = "my shop" });
            await _product.AddProductAsync(new Product { Name = "bread", Description = "my product" });
        }

        public async Task<ViewResult> ListS()
        {
            ViewBag.Shop = "A1";
              
         
            return View(_product.GetAllProductAsync().Result.ToList());
        }
    }
}
