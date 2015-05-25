namespace OpenMarket.MvcApp.Controllers
{
    using System.Web.Mvc;
    using Data;

    public class BaseController : Controller
    {
        private IOpenMarketData data;

        public IOpenMarketData Data
        {
            get { return this.data; }
        }

        public BaseController()
            : this(new OpenMarketData(new OpenMarketDbContext()))
        {

        }

        public BaseController(IOpenMarketData data)
        {
            this.data = data;
        }
    }
}