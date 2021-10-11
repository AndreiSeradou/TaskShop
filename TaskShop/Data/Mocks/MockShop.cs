using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskShop.Data.Mocks
{
    public class MockShop : IShop
    {


        public IEnumerable<IShop> AllShop
        {
            get
            {
                return new List<Shop>
                {
                    new Shop { }
                };
            }
        }
    }
}
