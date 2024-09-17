using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.Maui.LifecycleEvents;


namespace LearnMAUI.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureLifecycleEvents(AppLifecycle =>
            {
#if ANDROID
                    AppLifecycle.AddAndroid(android => android.OnCreate((Activity, Bundle) => 
                        {Debug.WriteLine("OnCreate called", "PSDEMO");
                        } ));
#endif

            })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
