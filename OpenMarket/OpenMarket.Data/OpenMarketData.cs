using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarket.Data
{
    using Model;
    using Repositories;

    public class OpenMarketData : IOpenMarketData
    {
        private IOpenMarketDbContext context;
        private IDictionary<Type, Object> repositories;

        public OpenMarketData(IOpenMarketDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Item> Items
        {
            get { return this.GetRepository<Item>(); }
            
        }

        public IRepository<Shop> Shops
        {
            get { return this.GetRepository<Shop>(); }
        }

        public IRepository<FavoritShop> FavoritShops
        {
            get { return this.GetRepository<FavoritShop>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<T>);
//                if (type.IsAssignableFrom(typeof(User)))
//                {
//                    repositoryType = typeof(UserRepository);
//                }
                this.repositories.Add(typeof(T), Activator.CreateInstance(repositoryType, this.context));
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}
