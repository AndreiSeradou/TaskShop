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
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetProductByShopAsync(int id);
        Task AddProductAsync(Product product);
        Task DeleteProductAsync(string name);
        Task DeleteProductAsync(int id);
    }
}
