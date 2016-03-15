using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using System.IO;

namespace BasicUI
{
	public partial class IndexViewController : UIViewController
	{
		UITableView sampleTableView;

//		public IndexViewController () : base ("IndexViewController", null)
//		{
//		}
		public IndexViewController ()
		{	
		}
				
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			this.View.BackgroundColor = UIColor.LightGray;
			this.bringIndexTableViewToFront ();


		}
		public void bringIndexTableViewToFront()
		{
			sampleTableView = new UITableView ();
			sampleTableView.Frame = new CoreGraphics.CGRect (this.View.Frame.X, this.View.Frame.Y+44, this.View.Frame.Width, this.View.Frame.Height);

			//Setting Table Source
			string[] tableItems = new string[] {"UILabel","UITextField","UIView","UIButton","UIToolBar","UINavigationBar","UITabBar","UIImageView","UIScrollView","UISplitView","UITextView","UIView Transitions", "UIPickerView","UISwitch","UISlider","UIAlertView","UIIcons","UISegmentContol","UISearchBar","UICollectionView","UIActivityIndicator","UIPageControl", "UIProgresssView","UIRefreshControl","UISlider","UIStepper" };


			sampleTableView.Source = new TableSource (tableItems, this);
			Add (sampleTableView);
			this.View.AddSubview (sampleTableView);
		}
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			//this.PerformSegue("segueToViewController", this);

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


