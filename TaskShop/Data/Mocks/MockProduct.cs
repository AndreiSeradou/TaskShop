using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Interfaces;
using TaskShop.Data.Models;

namespace TaskShop.Data.Mocks
{
    public class MockProduct : IProduct
    {
        public IEnumerable<Product> AllProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Product GetProdict(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
