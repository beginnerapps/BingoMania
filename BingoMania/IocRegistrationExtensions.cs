using BingoMania.Features.Database;
using BingoMania.Features.Startup;
using BingoMania.Framework.Navigation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;

namespace BingoMania
{
    internal static class IocRegistrationExtensions
    {
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<StartupPage>();
            return builder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<StartupPageViewModel>();
            return builder;
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<INavigation, NavigationService>();
            builder.Services.AddTransient<IStartupSequencer, StartupSequencer>();
            return builder;
        }

        public static MauiAppBuilder RegisterStartupSequenceItems(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<IStartupSequencer, StartupSequencer>();
            return builder;
        }

        public static MauiAppBuilder RegisterAppDb(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<IBingoManiaDb, BingoManiaDb>();
            return builder;
        }
    }
}
