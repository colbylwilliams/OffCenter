using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation;
using UIKit;

using NomadCode.MobileCenter;
using NomadCode.MobileCenter.Models;
using NomadCode.UIExtensions;


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

			return cell;
		}
	}
}
