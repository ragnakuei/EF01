using System.Data.Entity;
using System.Web.Http;
using EF01.EF;

namespace EF01
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<NorthwindDbContext>(null);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
