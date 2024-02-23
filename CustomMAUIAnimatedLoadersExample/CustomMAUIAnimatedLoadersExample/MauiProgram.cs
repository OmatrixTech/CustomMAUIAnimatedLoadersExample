using CommunityToolkit.Maui;
using MAUI.Custom.LoaderEase.AppPresentations.CommonSource;
using MAUI.Custom.LoaderEase.AppPresentations.Services;
using MAUI.Custom.LoaderEase.Interfaces;

namespace CustomMAUIAnimatedLoadersExample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            try
            {
                var builder = MauiApp.CreateBuilder();
                builder.UseMauiApp<App>().ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
                RegisterEssentials(builder.Services);
                RegisterPages(builder.Services);
                RegisterViewModels(builder.Services);
                builder.UseMauiCommunityToolkit();//Registering for MAUI loader
                var app = builder.Build();
                MauiServiceHandler.MauiAppBuilder = app;
                return app;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        static void RegisterPages(in IServiceCollection services)
        {
            services.AddTransient<MainPage>();
        }
        static void RegisterViewModels(in IServiceCollection services)
        {
            services.AddTransient<MainPageViewModel>();
        }
        static void RegisterEssentials(in IServiceCollection services)
        {
            //If the user intends to utilize this service through dependency injection,
            //they must register the loader service handler.
            services.AddSingleton<ICustomLoaderHandlerService, CustomLoaderHandlerService>();
        }
    }
}
