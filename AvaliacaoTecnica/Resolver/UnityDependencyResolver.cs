using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Unity;

namespace AvaliacaoTecnica.Resolver
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }
    }
}