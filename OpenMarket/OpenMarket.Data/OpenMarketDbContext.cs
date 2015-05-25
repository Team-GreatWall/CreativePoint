namespace OpenMarket.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model;

    public class OpenMarketDbContext : IdentityDbContext<User>, IOpenMarketDbContext
    {
        public OpenMarketDbContext()
            : base("OpenMarketDb", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<OpenMarketDbContext, OpenMarket.Data.Migrations.Configuration>());
        }

        public IDbSet<Item> Items { get; set; }

        public IDbSet<Shop> Shops { get; set; }

        public IDbSet<FavoritShop> FavoritShops { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static OpenMarketDbContext Create()
        {
            return new OpenMarketDbContext();
        }
    }
}
