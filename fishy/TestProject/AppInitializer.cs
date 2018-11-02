using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestProject
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.ApkFile("../../../fishy/fishy.Android/bin/Debug/com.companyname.fishy-Signed.apk").StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}