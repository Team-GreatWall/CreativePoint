namespace OpenMarket.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Model;

    public interface IOpenMarketDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Item> Items { get; set; }

        IDbSet<Shop> Shops { get; set; }

        IDbSet<FavoritShop> FavoritShops { get; set; } 
        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
