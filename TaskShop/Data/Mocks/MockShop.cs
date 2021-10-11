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
        public IEnumerable<Shop> AllShop
        {
            get
            {
                return new List<Shop>
                {
                    new Shop { Address = "123", Name = "123", OperatingMode = "1231431324" },
                    new Shop { Address = "1234", Name = "123", OperatingMode = "1231431324" }
                };
            }
        }
    }
}
