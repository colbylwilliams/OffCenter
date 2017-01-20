// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OffCenter.iOS
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UITextField usernameTextField { get; set; }

		[Action ("loginButtonClicked:")]
		partial void loginButtonClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameTextField != null) {
				usernameTextField.Dispose ();
				usernameTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}
		}
	}
}
