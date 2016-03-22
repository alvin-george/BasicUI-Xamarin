using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;

namespace BasicUI
{
	public class TableSource : UITableViewSource
	{
		IndexViewController owner;

		string[] TableItems;
		string CellIdentifier = "TableCell";	
		public event EventHandler<NSIndexPath> FundRequestSelected;

		public TableSource (string[] items , IndexViewController owner)
		{
			TableItems = items;
			this.owner = owner;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems [indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);
			}

			cell.TextLabel.Text = item;
			cell.BackgroundColor = UIColor.LightGray;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{

			tableView.DeselectRow (indexPath, true);

			if (FundRequestSelected != null)				
				FundRequestSelected (this, indexPath);

//			UIStoryboard board = UIStoryboard.FromName ("Main", null);
//
//			ViewController ctrl = (ViewController)board.InstantiateViewController ("viewControllerID");
//			owner.PresentViewController (ctrl, true, null);

			owner.PerformSegue("segueToViewController", this);
		}

	}
}

