using BingoMania.Platforms.iOS;
using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace BingoMania;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => Bootstrap.Initialize();
}
