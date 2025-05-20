using Catel;
using CommunityToolkit.Maui;
using FruitOder_20250428.Interfaces;
using FruitOder_20250428.Models;
using FruitOder_20250428.Pages;
using FruitOder_20250428.Services;
using FruitOder_20250428.ViewModels;
using Microsoft.Extensions.Logging;

namespace FruitOder_20250428;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit();
        builder.Services.AddSingleton<IPlatformHttpMessageHandler>(sp =>
        {
#if ANDROID
            return new Platforms.Android.AndroidHttpMessageHandler();
#elif IOS
			return new Platforms.iOS.IosHttpMessageHandler();
#else
            throw new PlatformNotSupportedException("Unsupported platform");
#endif
        });

        builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
        {
            var baseAddress = DeviceInfo.Platform == DevicePlatform.Android
                            ? "https://10.0.2.2:12345"
                            : "https://localhost:12345";
            httpClient.BaseAddress = new Uri(baseAddress);
        })
        //.ConfigureHttpMessageHandlerBuilder(configureBuilder =>
        //{
        //    var platformHttpMessageHandler = configureBuilder.Services.GetRequiredService<IPlatformHttpMessageHandler>();
        //    configureBuilder.PrimaryHandler = platformHttpMessageHandler.GetHttpMessageHandler();
        //});
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            return new HttpClientHandler
            {
                // Bỏ qua xác thực chứng chỉ - CHỈ DÙNG KHI DEV
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true
            };
        });

        builder.Services.AddSingleton<CategoryService>();
        builder.Services.AddSingleton<ProductsService>();
        builder.Services.AddTransient<OffersService>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<HomePage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
