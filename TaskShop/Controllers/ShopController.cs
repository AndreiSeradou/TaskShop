﻿using Microsoft.AspNetCore.Mvc;
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

        public ViewResult ShopList()
        {
            ViewBag.Shop = "Список магазинов";
            return View(_shop.GetAllShopAsync().Result.ToList());
        }
    }
}

