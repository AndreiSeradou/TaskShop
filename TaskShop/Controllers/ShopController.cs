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
        private async void addData()
        {
            await _shop.AddShopAsync(new Shop { Id = 1, Name = "Adidas", Address = "syrganovo 23", OperatingMode = "SHOOSE shop" });
            await _shop.AddShopAsync(new Shop { Id = 2, Name = "Nike", Address = "chekalovo 4", OperatingMode = "SHOOSE shop" });
            await _shop.AddShopAsync(new Shop { Id = 3, Name = "Abibas", Address = "fluchko 55", OperatingMode = "SHOOSE shop" });
            await _product.AddProductAsync(new Product { Id = 1, Name = "Adidas14", Description = "Adidas product", ShopId = 1 });
            await _product.AddProductAsync(new Product { Id = 2, Name = "PEGAS", Description = "Nike product", ShopId = 2 });
            await _product.AddProductAsync(new Product { Id = 3, Name = "Abibas V140", Description = "Abibas product", ShopId = 3 });
            await _product.AddProductAsync(new Product { Id = 1, Name = "Adidas FROK", Description = "Adidas product", ShopId = 1 });
            await _product.AddProductAsync(new Product { Id = 2, Name = "PEGAS HAMA", Description = "Nike product", ShopId = 2 });
            await _product.AddProductAsync(new Product { Id = 3, Name = "Abibas TOOL", Description = "Abibas product", ShopId = 3 });
            await _product.AddProductAsync(new Product { Id = 1, Name = "Adidas", Description = "Adidas product", ShopId = 1 });
            await _product.AddProductAsync(new Product { Id = 2, Name = "PEGASP", Description = "Nike product", ShopId = 2 });
            await _product.AddProductAsync(new Product { Id = 3, Name = "Abibas VS", Description = "Abibas product", ShopId = 3 });
        }
        public ViewResult ShopList()
        {
            if (_shop.isEmptyTable())
            {
                addData();
            }
            ViewBag.Shop = "Список магазинов";
            return View(_shop.GetAllShopAsync().Result.ToList());
        }
    }
}

