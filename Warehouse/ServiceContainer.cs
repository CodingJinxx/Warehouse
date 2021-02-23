using System;
using Microsoft.Extensions.DependencyInjection;

namespace Warehouse
{
    public static class ServiceContainer
    {
        public static IServiceProvider services { get; private set; }

        static ServiceContainer()
        {
            configure();
        }

        private static void configure()
        {
            IServiceCollection collection = new ServiceCollection();
            services = collection.BuildServiceProvider();
        }
    }
}