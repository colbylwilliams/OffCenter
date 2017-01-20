using System;

using Foundation;
using UIKit;
using OffCenter.Shared;
using NomadCode.UIExtensions;

namespace OffCenter.iOS
{
	public partial class BeaconTableViewController : UITableViewController
	{
		public BeaconTableViewController (IntPtr handle) : base (handle) { }

		public override nint RowsInSection (UITableView tableView, nint section) => Beacon.All.Count;


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var beacon = Beacon.All [(Beacons)indexPath.Row];

			var cell = tableView.Dequeue<BeaconTableViewCell> (indexPath);

			cell.TextLabel.Text = beacon.Title;

			var accessoryImageView = cell.AccessoryView as UIImageView;

			if (accessoryImageView != null)
			{
				accessoryImageView.Image = UIImage.FromBundle (beacon.Icon);
			}

			return cell;
		}
	}
}
