﻿using VaFoConnect.Client.Infrastructure.Managers;
using VaFoConnect.Client.Infrastructure.Managers.Interfaces;
using VaFoConnect.Core.Infrastructure.Providers.Interfaces;

namespace VaFoConnect.Client.Infrastructure
{
    public static class ContainerConfigurator
    {
        /// <summary>
        /// Initialize InstanceProvider only once per application!
        /// </summary>
        public static IInstanceProvider Initialize(this IInstanceProvider provider)
        {
            Core.Infrastructure.Configurations.ContainerConfigurator.Configure(provider);
            Configure(provider);

            return provider;
        }

        public static void Configure(IInstanceProvider instanceProvider)
        {
            RegisterComponents(instanceProvider);
        }

        private static void RegisterComponents(IInstanceProvider instanceProvider)
        {
            RegisterProviders(instanceProvider);
            RegisterManagers(instanceProvider);
            RegisterServices(instanceProvider);
        }

        private static void RegisterProviders(IInstanceProvider instanceProvider)
        {

        }

        private static void RegisterManagers(IInstanceProvider instanceProvider)
        {
            instanceProvider.Assign<IClientManager, ClientManager>();
            instanceProvider.Assign<IConnectionManager, ConnectionManager>();
        }

        private static void RegisterServices(IInstanceProvider instanceProvider)
        {
            
        }
    }
}