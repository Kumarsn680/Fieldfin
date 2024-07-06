using Fieldfin.MiddleWare;
using Fieldfin.Service;
using Fieldfin.View.FieldUser;
using Microsoft.Extensions.Logging;

namespace Fieldfin
{
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Register INavigation for navigation operations
           // builder.Services.AddSingleton<INavigation>(App.Current.Navigation);

            // Register other services for dependency injection
            builder.Services.AddSingleton<SessionService>(); // Session management service
            builder.Services.AddSingleton<LoginLogic>(); // Logic for handling login operations
            //builder.Services.AddSingleton<INavigationService, NavigationService>(); // Custom navigation service
            builder.Services.AddSingleton<UserDashboard>();
            return builder.Build();
        }
    }
}
