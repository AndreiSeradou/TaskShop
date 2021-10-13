using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Models;

namespace TaskShop.Data.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductAsync(string name);
        Task AddProductAsync(Product product);
        Task DeleteProductAsync(string name);
    }
}
