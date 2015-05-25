using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarket.Data
{
    using Model;
    using Repositories;

    public interface IOpenMarketData
    {
        IRepository<User> Users { get; }

        IRepository<Item> Items { get; }

        IRepository<Shop> Shops { get; }

        IRepository<FavoritShop> FavoritShops { get; } 

        int SaveChanges();
    }
}
