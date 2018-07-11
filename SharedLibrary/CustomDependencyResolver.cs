using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Microsoft.Extensions.DependencyInjection;

namespace SharedLibrary
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        private readonly ServiceProvider _provider;

        public CustomDependencyResolver(ServiceProvider provider)
        {
            _provider = provider;
        }

        public void Dispose()
        {
            //_provider.Dispose();
        }

        public object GetService(Type serviceType)
        {
            return _provider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _provider.GetServices(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }
}
