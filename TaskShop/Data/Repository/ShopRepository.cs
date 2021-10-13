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
    public class ShopRepository : IShop
    {
        private readonly AppDBContext _appDBContext;
        public ShopRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task AddShopAsync(Shop shop)
        {
            await _appDBContext.Shop.AddAsync(new Shop { Name = shop.Name, Address = shop.Address, OperatingMode = shop.OperatingMode}).ConfigureAwait(false);
            await _appDBContext.SaveChangesAsync().ConfigureAwait(false);
            
        }
        public bool isEmptyTable()
        {
            if (!_appDBContext.Shop.Any())
            {
                return true;
            }
            return false;
        }
        public async Task<IEnumerable<Shop>> GetAllShopAsync()
        {
            return await _appDBContext.Shop
               .AsNoTracking()
               .ToListAsync()
               .ConfigureAwait(false);
        }
    }
}
