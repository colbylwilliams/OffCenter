using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Rest;

using NomadCode.MobileCenter.Models;
using System.Linq;

namespace NomadCode.MobileCenter
{
	public class McClient
	{
		Keychain _keychain;
		Keychain keychain => _keychain ?? (_keychain = new Keychain ());


		MobileCenterClient mobileCenterClient { get; set; }


		static McClient _shared;
		public static McClient Shared => _shared ?? (_shared = new McClient ());


		public event EventHandler<bool> Authenticated;


		public List<AppResponse> Apps { get; set; } = new List<AppResponse> ();


		public async Task<bool> Login ()
		{
			var userCreds = keychain.GetItemFromKeychain (Keys.Keychain.Account);

			if (string.IsNullOrEmpty (userCreds?.Item1) || string.IsNullOrEmpty (userCreds?.Item2))
			{
				return false;
			}

			mobileCenterClient = new MobileCenterClient (new BasicAuthenticationCredentials
			{
				UserName = userCreds.Item1,
				Password = userCreds.Item2
			});

			try
			{
				var token = keychain.GetItemFromKeychain (Keys.Keychain.Token);

				if (string.IsNullOrEmpty (token?.Item1) || string.IsNullOrEmpty (token?.Item2))
				{
					var tokensObj = await mobileCenterClient.Account.CreateApiTokenAsync (new ApiTokensCreateRequest (Keys.Client.TokenDescription));

					var tokens = tokensObj as ApiTokensCreateResponse;

					if (!string.IsNullOrEmpty (tokens?.ApiToken))
					{
						keychain.SaveItemToKeychain (Keys.Keychain.Token, tokens.Id, tokens.ApiToken);

						mobileCenterClient.HttpClient.DefaultRequestHeaders.Add (Keys.Client.TokenHeader, tokens.ApiToken);
					}
				}
				else
				{
					mobileCenterClient.HttpClient.DefaultRequestHeaders.Add (Keys.Client.TokenHeader, token.Item2);
				}

				// this will fail if we're not authenticated
				var authed = await getApps ();

				Authenticated?.Invoke (this, authed);

				return authed;
			}
			catch (System.Exception ex)
			{
				System.Diagnostics.Debug.WriteLine (ex.Message);
				return false;
			}
		}


		async Task<bool> getApps ()
		{
			try
			{
				var appsObj = await mobileCenterClient.Account.GetAppsAsync ();

				var apps = appsObj as List<AppResponse>;

				Apps = apps.OrderBy (a => a.DisplayName).ToList ();

				return Apps?.Count > 0;
			}
			catch (System.Exception ex)
			{
				System.Diagnostics.Debug.WriteLine (ex.Message);
				return false;
			}
		}


		public void StoreCredentials (string username, string password) => keychain.SaveItemToKeychain (Keys.Keychain.Account, username, password);
	}
}