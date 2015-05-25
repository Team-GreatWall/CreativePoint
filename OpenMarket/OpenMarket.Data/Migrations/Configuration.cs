namespace OpenMarket.Data.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OpenMarket.Data.OpenMarketDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OpenMarket.Data.OpenMarketDbContext context)
        {
        }
    }
}
