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
        public IEnumerable<Product> AllProduct 
        {   get 
            {
                return new List<Product>
                {
                    new Product { Name = "wwrw", Description = "ewffwe"}
                };
            
            } 
        }

        public Product GetProdict(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
