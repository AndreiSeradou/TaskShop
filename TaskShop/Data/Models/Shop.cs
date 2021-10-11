using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskShop.Data.Models
{
    public class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string OperatingMode { get; set; }
        public List<Product> Products { get; set; }
    }
}
