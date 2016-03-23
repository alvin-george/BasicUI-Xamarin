using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel.Design;

namespace BasicUI
{
	public partial class IndexViewController : UIViewController
	{
		UITableView sampleTableView;

		public IndexViewController ()
		{	
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = "Select a UI Component";


			this.bringIndexTableViewToFront ();		

		}

		public void bringIndexTableViewToFront ()
		{
			sampleTableView = new UITableView ();
			sampleTableView.Frame = new CoreGraphics.CGRect (this.View.Frame.X, this.View.Frame.Y, this.View.Frame.Width, this.View.Frame.Height);

			//Setting Table Source
			string[] tableItems = new string[] {
				"UILabel",
				"UITextField",
				"UIView",
				"UIButton",
				"UIToolBar",
				"UINavigationBar",
				"UITabBar",
				"UIImageView",
				"UIScrollView",
				"UITextView",
				"UIView Transitions",
				"UIPickerView",
				"UISwitch",
				"UISlider",
				"UIAlertView",
				"UISegmentContol",
				"UISearchBar",
				"UICollectionView",
				"UIActivityIndicator",
				"UIProgresssView",
				"UIRefreshControl",
				"UIStepper"
			};

			sampleTableView.Source = new TableSource (tableItems, this);
			Add (sampleTableView);
			this.View.AddSubview (sampleTableView);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{			
			base.PrepareForSegue (segue, sender);
//			var callHistoryContoller = segue.DestinationViewController as CallHistoryController;
//
//			if (callHistoryContoller != null) {
//				callHistoryContoller.PhoneNumbers = PhoneNumbers;
//			}
		}

	}
}


