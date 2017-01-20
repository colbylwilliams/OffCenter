﻿using Foundation;
using UIKit;

namespace OffCenter.iOS
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }


		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			UITabBar.Appearance.TintColor = Colors.Theme;

			return true;
		}
	}
}

