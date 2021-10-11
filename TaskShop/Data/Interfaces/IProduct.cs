using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskShop.Data.Models;

namespace TaskShop.Data.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> AllProduct { get; set; }
        Product GetProdict(int ProductId);
    }
}
