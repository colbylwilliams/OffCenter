using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation;
using UIKit;

using NomadCode.MobileCenter;
using NomadCode.MobileCenter.Models;
using NomadCode.UIExtensions;
using System.Linq;


namespace OffCenter.iOS
{
	public partial class AppsTableViewController : UITableViewController
	{
		public List<AppResponse> Apps => McClient.Shared.Apps;


		public AppsTableViewController (IntPtr handle) : base (handle) { }


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}


		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);


			Task.Run (async () =>
			{
				var auth = await McClient.Shared.Login ();

				BeginInvokeOnMainThread (() =>
				{
					if (auth)
					{
						TableView.ReloadData ();
					}
					else
					{
						var controller = Storyboard.Instantiate<LoginNavigationController> ();

						PresentViewController (controller, true, null);
					}
				});
			});
		}


		public override nint RowsInSection (UITableView tableView, nint section) => Apps.Count;


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var app = Apps [indexPath.Row];

			var cell = tableView.Dequeue<AppsTableViewCell> (indexPath);

			cell.TextLabel.Text = $"{app.DisplayName}";

			cell.DetailTextLabel.Text = $"for {app.Os}";

			cell.ImageView.Image = UIImage.FromBundle (getDefaultIcon (app.DisplayName));

			var label = cell.ImageView.Subviews.FirstOrDefault () as UILabel;

			if (label == null)
			{
				label = new UILabel { Font = UIFont.SystemFontOfSize (22), TextAlignment = UITextAlignment.Center };

				cell.ImageView.AddSubview (label);

				label.ConstrainToFitParent (cell.ImageView);
			}

			label.TextColor = getDefaultIconTextColor (app.DisplayName);

			label.Text = char.ToUpperInvariant (app.DisplayName.FirstOrDefault ()).ToString ();


			if (indexPath.Row % 3 == 0)
			{
				cell.Accessory = UITableViewCellAccessory.None;
			}
			else
			{
				cell.TintColor = UIColor.Green;
				cell.Accessory = UITableViewCellAccessory.Checkmark;
			}

			return cell;
		}


		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var controller = Storyboard.Instantiate<BeaconTableViewController> ();

			ShowViewController (controller, this);
		}

		string getDefaultIcon (string name)
		{
			var firstLetter = char.ToLowerInvariant (name.FirstOrDefault ());

			if (firstLetter < 'p') return "i_app_icon_default_green";

			if (firstLetter < 's') return "i_app_icon_default_yellow";

			if (firstLetter < 't') return "i_app_icon_default_orange";

			if (firstLetter < 'u') return "i_app_icon_default_purple";

			if (firstLetter < 'x') return "i_app_icon_default_blue";

			return "i_app_icon_default_green";
		}

		UIColor getDefaultIconTextColor (string name)
		{
			var firstLetter = char.ToLowerInvariant (name.FirstOrDefault ());

			if (firstLetter < 'p') return Colors.DefaultIconText.Green;

			if (firstLetter < 's') return Colors.DefaultIconText.Yellow;

			if (firstLetter < 't') return Colors.DefaultIconText.Orange;

			if (firstLetter < 'u') return Colors.DefaultIconText.Purple;

			if (firstLetter < 'x') return Colors.DefaultIconText.Blue;

			return Colors.DefaultIconText.Green;
		}

	}
}
