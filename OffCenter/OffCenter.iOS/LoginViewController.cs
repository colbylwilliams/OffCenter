using System;

using Foundation;
using UIKit;

using NomadCode.MobileCenter;

namespace OffCenter.iOS
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController (IntPtr handle) : base (handle) { }

		partial void loginButtonClicked (NSObject sender)
		{
			if (!string.IsNullOrEmpty (usernameTextField.Text) && !string.IsNullOrEmpty (passwordTextField.Text))
			{
				McClient.Shared.StoreCredentials (usernameTextField.Text, passwordTextField.Text);

				DismissViewController (true, null);
			}
		}
	}
}
