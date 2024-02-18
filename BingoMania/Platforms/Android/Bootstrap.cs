using BingoMania.Features.Environment;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Platforms.Android
{
    internal static class Bootstrap
    {
        public static MauiApp Initialize()
        {
            var builder = MauiApp.CreateBuilder();
            RegisterPlatformSpecific(builder);

            return MauiProgram.CreateMauiApp(builder);
        }

        private static void RegisterPlatformSpecific(MauiAppBuilder builder)
        {
            //Todo register platform specific dependencies
            builder.Services.AddSingleton<IEnvironmentContext, EnvironmentContext>();
        }
    }
}
