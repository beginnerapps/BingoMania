using Android.App;
using Android.Runtime;
using BingoMania.Platforms.Android;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace BingoMania;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => Bootstrap.Initialize();
}
