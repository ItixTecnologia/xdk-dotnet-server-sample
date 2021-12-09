using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using XDK.Mobile.Extensions;
using XDK.Sample.Mobile.Maui.Persistence;
using XDK.Mobile.Models;
using XDK.Data.EntityFramework.Extensions;
using XDK.Sample.Mobile.Maui.Stores;
using XDK.Sample.Mobile.Maui.Models;
using System;

namespace XDK.Sample.Mobile.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .AddXdkMobile(new IxMobileConfig
                {
                    BaseUrl = "http://192.168.31.200:8080"
                })
                .AddXdkStores<TestStore, TestModel, Guid>() // Opcional.
                .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));
            builder.Services.AddXdkPersistence<MobileSampleContext>(); // Opcional.

            return builder.Build();
        }
    }
}