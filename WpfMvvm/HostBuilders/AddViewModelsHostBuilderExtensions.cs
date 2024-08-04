using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using WpfMvvm.Factories;
using WpfMvvm.ViewModels;
using WpfMvvm.ViewModels.Factories;

namespace WpfMvvm.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddTransient<RadarsViewModel>();
                services.AddTransient<PlatformsViewModel>();
                services.AddTransient<MainViewModel>();

                services.AddSingleton<CreateViewModel<RadarsViewModel>>(services => () => services.GetRequiredService<RadarsViewModel>());
                services.AddSingleton<CreateViewModel<PlatformsViewModel>>(services => () => services.GetRequiredService<PlatformsViewModel>());
                services.AddSingleton<IWpfMvvmViewModelFactory, WpfMvvmViewModelFactory>();
            });

            return host;
        }
    }
}
