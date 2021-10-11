using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskShop.Data.Interfaces
{
    public interface IShop
    {
        IEnumerable<IShop> AllShop { get; }
    }
}
