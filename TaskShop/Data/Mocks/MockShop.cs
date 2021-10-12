using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Interfaces;
using TaskShop.Data.Models;

namespace TaskShop.Data.Mocks
{
    public class MockShop : IShop
    {
        private readonly IProduct _product = new MockProduct();

        public IEnumerable<Shop> AllShop
        {
            
            get
            {
                return new List<Shop>
                {
                    new Shop { Address = "1123", Name = "123", OperatingMode = "1231431324", Products = _product.AllProduct.ToList() },
                    new Shop { Address = "1123", Name = "11111123", OperatingMode = "1231431324", Products = _product.AllProduct.ToList() },
                    new Shop { Address = "1234", Name = "11112223444423", OperatingMode = "1231431324", Products = _product.AllProduct.ToList() }
                };
            }
        }
    }
}
