using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using EF01.EF;

namespace EF01.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly NorthwindDbContext _dbContext;

        public OrdersController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IHttpActionResult Get()
        {
            var data = _dbContext.Orders
                                 .AsNoTracking()
                                 .Include(o=>o.OrderDetails)
                                 .ToArray();
            return Json(data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
