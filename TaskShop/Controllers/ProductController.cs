using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Interfaces;

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


        public ViewResult ProductList(int id)
        {
            ViewBag.Shop = "Список продуктов";
            return View(_product.GetProductByShopAsync(id).Result);
        }
    }
}
