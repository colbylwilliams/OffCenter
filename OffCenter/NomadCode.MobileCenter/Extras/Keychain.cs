﻿using System;

#if __IOS__
using Foundation;
using Security;
#endif

namespace NomadCode.MobileCenter
{
	public class Keychain
	{
#if __IOS__

		SecRecord genericRecord (string service) => new SecRecord (SecKind.GenericPassword)
		{
			Service = $"{NSBundle.MainBundle.BundleIdentifier}-{service}"
		};


		public Tuple<string, string> GetItemFromKeychain (string service)
		{
			SecStatusCode status;

			var record = SecKeyChain.QueryAsRecord (genericRecord (service), out status);

			if (status == SecStatusCode.Success && record != null)
			{
				var account = record.Account;

				var privateKey = NSString.FromData (record.ValueData, NSStringEncoding.UTF8).ToString ();

				return new Tuple<string, string> (account, privateKey);
			}

			return null;
		}


		public bool SaveItemToKeychain (string service, string account, string privateKey)
		{
			var record = genericRecord (service);

			record.Account = account;

			record.ValueData = NSData.FromString (privateKey, NSStringEncoding.UTF8);

			// Delete any existing items
			SecKeyChain.Remove (record);

			// Add the new keychain item
			var status = SecKeyChain.Add (record);

			var success = status == SecStatusCode.Success;

			if (!success)
			{
				System.Diagnostics.Debug.WriteLine ($"Error in Keychain: {status}");
				System.Diagnostics.Debug.WriteLine ($"If you are seeing error code '-34018' got to Project Options -> iOS Bundle Signing -> make sure Entitlements.plist is populated for Custom Entitlements for iPhoneSimulator configs");
			}

			return success;
		}


		void removeItemFromKeychain (string service)
		{
			var record = genericRecord (service);

			SecKeyChain.Remove (record);
		}

#else

		// to implement, check out the links below:
		// https://github.com/sameerkapps/SecureStorage/blob/master/SecureStorage/Plugin.SecureStorage.Android/SecureStorageImplementation.cs
		// https://github.com/xamarin/Xamarin.Auth/blob/portable-bait-and-switch/source/Xamarin.Auth.XamarinAndroid/PlatformSpecific/AndroidAccountStore.cs
		// https://github.com/xamarin/Xamarin.Auth/blob/portable-bait-and-switch/source/Xamarin.Auth.XamarinAndroid/PlatformSpecific/AndroidAccountStore.Async.cs


		Tuple<string, string> getItemFromKeychain (string service)
		{
			throw new NotImplementedException ();
		}


		bool saveItemToKeychain (string service, string account, string privateKey)
		{
			throw new NotImplementedException ();
		}


		void removeItemFromKeychain (string service)
		{
			throw new NotImplementedException ();
		}
#endif
	}
}
