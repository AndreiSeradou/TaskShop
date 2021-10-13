using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.DB;
using TaskShop.Data.Interfaces;
using TaskShop.Data.Models;

namespace TaskShop.Data.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly AppDBContext _appDBContext;
        public ProductRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await _appDBContext.Product
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task AddProductAsync(Product product)
        {
            await _appDBContext.Product.AddAsync(new Product { Name = product.Name, Description = product.Description, ShopId = product.ShopId}).ConfigureAwait(false);
            await _appDBContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteProductAsync(string name)
        {
            var entity = await GetProductAsync(name).ConfigureAwait(false);
            if (entity != null)
            {
                _appDBContext.Product.Remove(entity);
                await _appDBContext.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            var entity = await GetProductAsync(id).ConfigureAwait(false);
            if (entity != null)
            {
                _appDBContext.Product.Remove(entity);
                await _appDBContext.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        public Task<Product> GetProductAsync(string name)
        {
            return _appDBContext.Product
                .AsNoTracking()
                .FirstOrDefaultAsync(product => product.Name == name)!;
        }

        public Task<Product> GetProductAsync(int id)
        {
            return _appDBContext.Product
                .AsNoTracking()
                .FirstOrDefaultAsync(product => product.Id == id)!;
        }

        public async Task<IEnumerable<Product>> GetProductByShopAsync(int id)
        {
            return await _appDBContext.Product.AsNoTracking().Where(p => p.ShopId == id).ToListAsync();

        }
    }
}
