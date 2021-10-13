using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Models;

namespace TaskShop.Data.Interfaces
{
    public interface IShop
    {
        Task<IEnumerable<Shop>> GetAllShopAsync();
        Task AddShopAsync(Shop shop);
        public bool isEmptyTable();
    }
}
