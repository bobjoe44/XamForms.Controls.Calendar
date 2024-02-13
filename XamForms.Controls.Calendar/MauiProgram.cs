

using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace XamForms.Controls;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>();

        return builder.Build();
    }
}
