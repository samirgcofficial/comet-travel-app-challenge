﻿using Foundation;
using Microsoft.Maui.Hosting;

namespace CometTravelApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}