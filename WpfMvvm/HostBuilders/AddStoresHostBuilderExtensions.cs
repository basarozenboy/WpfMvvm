﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfMvvm.State.Navigators;

namespace WpfMvvm.HostBuilders
{
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigator, Navigator>();
            });

            return host;
        }
    }
}
