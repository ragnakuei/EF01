using System.Web.Http;
using EF01.Controllers;
using EF01.EF;
using Microsoft.Extensions.DependencyInjection;
using SharedLibrary;

namespace EF01
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var services = new ServiceCollection();
            services.AddTransient<OrdersController>();
            services.AddScoped<NorthwindDbContext>( t => NorthwindDbContext.Create());

            var provider = services.BuildServiceProvider();
            config.DependencyResolver = new CustomDependencyResolver(provider);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
