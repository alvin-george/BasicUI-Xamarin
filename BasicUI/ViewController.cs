using System;
using CoreGraphics;
using UIKit;
using Foundation;
using System.Runtime.Remoting.Channels;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Timers;
using System.Diagnostics;
using ObjCRuntime;
using System.Collections.Generic;
using System.Dynamic;
using CoreGraphics;


namespace BasicUI
{
	public partial class ViewController : UIViewController
	{
		String uiElementNameString;
		UINavigationController navigationController;
	
		UILabel sampleLabel1;
		UILabel sampleLable2;

		UITextField sampleTextField1;
		UITextField sampleTextField2;

		UIView sampleView1;
		UIButton sampleButton1;
		UIToolbar sampleToolBar1;

		UINavigationBar sampleNavigationBar;
		UITabBar sampleTabBar;
		UIImageView sampleImageView;

		UIScrollView sampleScrollView;
		UITextView sampleTextView;
		UIView transitionView;

		UIPickerView samplePicker;
		UISwitch sampleSwitch;
		UISlider sampleSlider;

		UISegmentedControl sampleSegmentControl;
		UISearchBar sampleSearchBar;
		UICollectionView sampleCollectionView;

		UIActivityIndicatorView sampleIndicator;
		UIProgressView sampleProgressView;

		UITableView sampleRefreshControlTableView;
		UIRefreshControl sampleRefreshConrtrol;
		UIStepper sampleStepper;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();		
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			//this.addUILabelToView ();
			//this.addUITextFieldToView ();
			//this.addUIViewToViewController ();
			//this.addUIButtonToView ();
			//this.addUIToolBarToView ();
			//this.addUINavigationBarToViewController ();
			//this.addUITabBarToView ();
			//this.addUIImageViewToView ();
			//this.addScrollViewToView ();
			//this.addUITextViewToView ();
			//this.addUIViewTransitionsToView ();
			//this.addUIPickerViewToView ();
			//this.addUISwitchToView ();
			//this.addUISliderToView ();
			//this.addUIAlertViewToView ();
			//this.addUISegmentControlToView ();
			//this.addSearchBarToView ();
			//this.addUICollectionViewToView ();
			//this.addUIActivityIndicatorToView ();
			//this.addUIProgressViewToView ();
			//this.addUIRefreshControlToView ();
			this.addUIStepperToView ();
		}

		public void addUILabelToView ()
		{
			
			sampleLabel1 = new UILabel ();
			sampleLabel1.Frame = new CoreGraphics.CGRect (50f, 100f, 300f, 50f);
			sampleLabel1.Text = "This is Xamarin iOS UILabel";
			sampleLabel1.BackgroundColor = UIColor.LightGray;
			sampleLabel1.Alpha = 1.0f;
			sampleLabel1.TextAlignment = UITextAlignment.Center;
			sampleLabel1.Font = UIFont.FromName (name: "Arial", size: 25f);
			sampleLabel1.Lines = 0;


			//Additional
			sampleLable2 = new UILabel ();
			sampleLable2.Frame = new CoreGraphics.CGRect (this.View.Frame.X + 5, this.View.Frame.Y + 250, this.View.Frame.Width - 10, this.View.Frame.Height / 3);
			sampleLable2.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Real-Estate_4.jpg"));
			sampleLable2.AdjustsFontSizeToFitWidth = true; 
			sampleLable2.MinimumFontSize = 12f;

			//Text Wrap
			sampleLable2.LineBreakMode = UILineBreakMode.TailTruncation;
			sampleLable2.Lines = 3; 

			//Setting Boarder and curved edges
			sampleLable2.Layer.BorderWidth = 1f;
			sampleLable2.Layer.CornerRadius = 5f;
			sampleLable2.Layer.BorderColor = UIColor.Black.CGColor;

			//Shadows
			sampleLable2.Layer.ShadowColor = UIColor.DarkGray.CGColor;
			sampleLable2.ShadowOffset = new CoreGraphics.CGSize (3f, 3f);
			sampleLable2.Layer.ShadowOpacity = 0.3f;
			sampleLable2.Layer.ShadowRadius = 3f;

			//Add to view
			this.View.AddSubview (sampleLabel1);
			this.View.AddSubview (sampleLable2);
		}

		public void addUITextFieldToView ()
		{
			//Initiate UITextField Delegates
			sampleTextField1 = new UITextField ();
			sampleTextField1.Frame = new CoreGraphics.CGRect (10f, 100f, 300f, 50f);
			//sampleTextField1.Text = "This is Xamarin iOS TextField";
			sampleTextField1.BackgroundColor = UIColor.LightGray;
			sampleTextField1.Alpha = 1.0f;
			sampleTextField1.TextAlignment = UITextAlignment.Center;
			sampleTextField1.Font = UIFont.FromName (name: "Arial", size: 15f);

			sampleTextField1.Placeholder = "Enter text here";
			sampleTextField1.KeyboardType = UIKeyboardType.EmailAddress;
			sampleTextField1.ReturnKeyType = UIReturnKeyType.Default;
			sampleTextField1.MinimumFontSize = 17f;
			sampleTextField1.AdjustsFontSizeToFitWidth = true;

			//Additional
			sampleTextField2 = new UITextField ();
			sampleTextField2.Frame = new CoreGraphics.CGRect (this.View.Frame.X + 5, this.View.Frame.Y + 250, this.View.Frame.Width - 10, this.View.Frame.Height / 3);
			sampleTextField2.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Real-Estate_4.jpg"));
			sampleTextField2.AdjustsFontSizeToFitWidth = true; 
			sampleTextField2.MinimumFontSize = 12f;

			//Setting Boarder and curved edges
			sampleTextField2.Layer.BorderWidth = 1f;
			sampleTextField2.Layer.CornerRadius = 5f;
			sampleTextField2.Layer.BorderColor = UIColor.Black.CGColor;

			//Shadows
			sampleTextField2.Layer.ShadowColor = UIColor.DarkGray.CGColor;
			sampleTextField2.Layer.ShadowOffset = new CoreGraphics.CGSize (3f, 3f);
			sampleTextField2.Layer.ShadowOpacity = 0.3f;
			sampleTextField2.Layer.ShadowRadius = 3f;

			this.View.AddSubview (sampleTextField1);
			this.View.AddSubview (sampleTextField2);

			//Adding Delegate Methods
			this.enableUITextFieldDelegateMethods ();

		}

		public void addUIViewToViewController ()
		{
			sampleView1 = new UIView ();
			sampleView1.Frame = new CoreGraphics.CGRect (10f, 100f, 300f, 250f);
			sampleView1.BackgroundColor = UIColor.Brown;
			sampleView1.Layer.CornerRadius = 25;
			sampleView1.Layer.BorderWidth = 2;
			this.View.AddSubview (sampleView1);
						
		}

		void enableUITextFieldDelegateMethods ()
		{
			this.sampleTextField1.ShouldReturn += (textField) => {
				sampleTextField2.BecomeFirstResponder ();
				textField.ResignFirstResponder ();
				return true;
			};

			this.sampleTextField1.ShouldBeginEditing += (textField) => {
				//Write here
				return true;
			};

			this.sampleTextField1.ShouldEndEditing += (textField) => {
				//Write here
				return true;
			};
			this.sampleTextField1.ShouldClear += (textField) => {
				//Write here
				return true;
			};

			this.sampleTextField1.ShouldChangeCharacters = (UITextField txt, NSRange range, string sampleTxt) => {
				var newLength = txt.Text.Length + sampleTxt.Length - range.Length;
				return newLength <= 9;

			};
		}

		public void addUIButtonToView ()
		{			
			this.sampleButton1 = new UIButton (UIButtonType.RoundedRect);	
			sampleButton1.Frame = new CoreGraphics.CGRect (10f, 100f, 300f, 50f);
			this.sampleButton1.SetTitle ("Sample Button", UIControlState.Normal);
			this.sampleButton1.SetNeedsLayout ();
			sampleButton1.TouchUpInside += OnSpeakButtonTapped;

			this.View.AddSubview (sampleButton1);

			// Here is where the lowest-level event handler is applied to the speak button.


		}

		void OnSpeakButtonTapped (object sender, EventArgs e)
		{
			// This is the event handler for the actual UIButton TouchUpInside event.	
			Console.WriteLine ("button tapped");
		}

		void addUIToolBarToView ()
		{

			sampleToolBar1 = new UIToolbar ();
			sampleToolBar1.Frame = new CoreGraphics.CGRect (50f, 100f, 300f, 50f);

			var browserButton = new UIBarButtonItem ("Browser", UIBarButtonItemStyle.Plain, null);
			browserButton.Clicked += (sender, e) => {
				Console.WriteLine ("bar button tapped");
			};
			var backButton = new UIBarButtonItem ("Back", UIBarButtonItemStyle.Plain, null);
			var forwardButton = new UIBarButtonItem ("Forward", UIBarButtonItemStyle.Plain, null);
			sampleToolBar1.Items = new UIBarButtonItem[] { backButton, forwardButton, browserButton };
			this.View.AddSubview (sampleToolBar1);		
		}

		void addUINavigationBarToViewController ()
		{				
			sampleNavigationBar = new UINavigationBar ();
			sampleNavigationBar.Frame = new CoreGraphics.CGRect (0f, 44f, 300f, 50f);

			var navigationItem1 = new UINavigationItem (title : "Item 1");
			var navigationBarButtonItem2 = new UIBarButtonItem ("Item 2", UIBarButtonItemStyle.Done, null);

			navigationItem1.RightBarButtonItem = navigationBarButtonItem2;

			sampleNavigationBar.Items = new UINavigationItem[] { navigationItem1 };
			this.View.AddSubview (sampleNavigationBar);

		}

		void barButtonTapped (String barButtonName)
		{
			UIAlertController okAlertController = UIAlertController.Create ("UIButton Selected", barButtonName, UIAlertControllerStyle.Alert);
			okAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default, null));
			this.PresentViewController (okAlertController, true, null);			
		}

		void addUITabBarToView ()
		{
			sampleTabBar = new UITabBar ();
			sampleTabBar.Frame = new CoreGraphics.CGRect (10f, 44f, this.View.Frame.Width - 10, 50f);

			var tabBarItem = new UITabBarItem ("TAB BAR ITEM", null, 4);
			sampleTabBar.Items = new UITabBarItem[]{ tabBarItem };
			sampleTabBar.ItemSelected += (sender, e) => {
				Console.WriteLine ("tab bar button item slected");
			};

			this.View.AddSubview (sampleTabBar);
		}

		void addUIImageViewToView ()
		{
			sampleImageView = new UIImageView (new CoreGraphics.CGRect (10f, 44f, this.View.Frame.Width - 20, 150f));
			sampleImageView.Image = UIImage.FromFile ("Real-Estate_4.jpg");
			sampleImageView.UserInteractionEnabled = true;
			sampleImageView.TintColor = UIColor.Brown;
			sampleImageView.Highlighted = true;

			//Tapping ImageView
			var tapGesture = new UITapGestureRecognizer (OnImageViewTap);		
			sampleImageView.AddGestureRecognizer (tapGesture);

			this.View.AddSubview (sampleImageView);
		}

		private void OnImageViewTap (UIGestureRecognizer gesture)
		{
			sampleImageView.Frame = new CoreGraphics.CGRect (10f, 44f, this.View.Frame.Width - 20, 350f);

		}

		private void addScrollViewToView ()
		{
			sampleScrollView = new UIScrollView (new CoreGraphics.CGRect (10f, 44f, this.View.Frame.Width, this.View.Frame.Height + 100));
			sampleScrollView.BackgroundColor = UIColor.Clear;
			sampleScrollView.Bounces = true;
			sampleScrollView.ShowsVerticalScrollIndicator = true;

			var imageView = new UIImageView (UIImage.FromFile ("Real-Estate_4.jpg"));
			sampleScrollView.ContentSize = imageView.Image.Size;
			sampleScrollView.AddSubview (imageView);
			this.View.AddSubview (sampleScrollView);
		}

		private void addSplitViewToVIew ()
		{
			
		}

		private void addUITextViewToView ()
		{
			sampleTextView = new UITextView (new CoreGraphics.CGRect (10f, 44f, this.View.Frame.Width - 20, 350f));
			sampleTextView.TintColor = UIColor.Brown;
			sampleTextView.Text = "sample Text View Text";
			sampleTextView.Editable = true;
			sampleTextView.BackgroundColor = UIColor.LightGray;
			sampleTextView.EnablesReturnKeyAutomatically = true;

			this.enableUITextViewDelegateMethods ();
			this.View.AddSubview (sampleTextView);
		}

		private void enableUITextViewDelegateMethods ()
		{
			sampleTextView.ShouldBeginEditing += (textView) => {
				//Write here
				Console.WriteLine ("textView begin editing");
				return true;
			};
			sampleTextView.ShouldEndEditing += (textView) => {
				//Write here
				textView.ResignFirstResponder ();
				return true;
			};
		}

		private void addUIViewTransitionsToView ()
		{
			transitionView = new UIView (new CoreGraphics.CGRect (10f, 244f, this.View.Frame.Width - 20, 250f));
			transitionView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Real-Estate_4.jpg"));
			this.View.AddSubview (transitionView);


			var sampletransitionViewButton = new UIButton (UIButtonType.RoundedRect);	
			sampletransitionViewButton.Frame = new CoreGraphics.CGRect (10f, 100f, 300f, 50f);
			sampletransitionViewButton.SetTitle ("Make Transition", UIControlState.Normal);
			sampletransitionViewButton.SetNeedsLayout ();
			sampletransitionViewButton.TouchUpInside += sampletransitionViewButtonTapped;
			this.View.AddSubview (sampletransitionViewButton);

		}

		private void sampletransitionViewButtonTapped (object sender, EventArgs e)
		{
			UIView.Transition (fromView: transitionView, toView: transitionView, duration: .5, options: UIViewAnimationOptions.TransitionCrossDissolve, completion: () => { 
				transitionView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("bid_auction.png"));
				this.View.AddSubview (transitionView);
				Console.WriteLine ("transition complete"); 
			});
		}

		private void addUIPickerViewToView ()
		{
			samplePicker = new UIPickerView (new CoreGraphics.CGRect (10f, 244f, this.View.Frame.Width - 20, 250f));
			samplePicker.BackgroundColor = UIColor.LightGray;
			samplePicker.Model = new StatusPickerViewModel ();
			this.View.AddSubview (samplePicker);	
		}

		public class StatusPickerViewModel : UIPickerViewModel
		{
			public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
			{
				return 5;
			}

			public override string GetTitle (UIPickerView pickerView, nint row, nint component)
			{				
				return "Picker Title";
			}

			public override nint GetComponentCount (UIPickerView pickerView)
			{

				return 1;
			}

		}

		private void addUISwitchToView ()
		{

			var sampleSwitchDemoView = new UIView (new CoreGraphics.CGRect (10f, 244f, this.View.Frame.Width - 20, 250f));
			this.View.AddSubview (sampleSwitchDemoView);


			sampleSwitch = new UISwitch ();
			sampleSwitch.Frame = new CoreGraphics.CGRect (100f, 100f, 10f, 10f);
			sampleSwitch.ValueChanged += delegate {
				if (sampleSwitch.On) {					
					Console.WriteLine ("TRUE");	
					sampleSwitchDemoView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Real-Estate_4.jpg"));

				} else {
					Console.WriteLine ("FALSE");
					sampleSwitchDemoView.BackgroundColor = UIColor.White;
				}
			};
			this.View.AddSubview (sampleSwitch);

		}

		private void addUISliderToView ()
		{
			var sampleSliderDemoView = new UIView (new CoreGraphics.CGRect (10f, 244f, this.View.Frame.Width - 20, 250f));
			sampleSliderDemoView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Real-Estate_4.jpg"));
			this.View.AddSubview (sampleSliderDemoView);

			var sampleSliderValueLabel = new UILabel ();
			sampleSliderValueLabel.Frame = new CoreGraphics.CGRect (100f, 100f, 300f, 50f);
			sampleSliderValueLabel.Text = "Slider Value : ";
			this.View.AddSubview (sampleSliderValueLabel);

			sampleSlider = new UISlider ();		
			sampleSlider.Frame = new CoreGraphics.CGRect (50f, 170f, this.View.Frame.Width - 100, 10f);
			sampleSlider.ValueChanged += delegate {

				sampleSliderDemoView.Alpha = sampleSlider.Value;
				sampleSliderValueLabel.Text = "Slider Value : " + sampleSlider.Value;

			};
			this.View.AddSubview (sampleSlider);
		}

		private void addUIAlertViewToView ()
		{

			var alert = UIAlertController.Create ("Error", "Something went wrong", UIAlertControllerStyle.Alert);
			alert.AddAction (UIAlertAction.Create ("Ok", UIAlertActionStyle.Destructive, null));
			alert.AddAction (UIAlertAction.Create ("Cancel", UIAlertActionStyle.Cancel, a => 

				//Write Action here
				Console.WriteLine ("Cancel Clicked")
			
			));
			this.PresentViewController (alert, animated: true, completionHandler: null);

			var sampleTimer = NSTimer.CreateRepeatingScheduledTimer (TimeSpan.FromSeconds (5.0), delegate {
				
				var alertSheet = UIAlertController.Create ("Error", "Something went wrong", UIAlertControllerStyle.ActionSheet);
				alertSheet.AddAction (UIAlertAction.Create ("Ok", UIAlertActionStyle.Destructive, null));
				alertSheet.AddAction (UIAlertAction.Create ("Cancel", UIAlertActionStyle.Cancel, a => 

					//Write Action here
					Console.WriteLine ("Cancel Clicked")

				));
				this.PresentViewController (alertSheet, animated: true, completionHandler: null);

			});		


		}

		private void addUISegmentControlToView ()
		{
			sampleSegmentControl = new UISegmentedControl (new CoreGraphics.CGRect (20, 20, 280, 40));
			sampleSegmentControl.InsertSegment ("One", 0, false);
			sampleSegmentControl.InsertSegment ("Two", 1, false);
			sampleSegmentControl.SelectedSegment = 1;

			sampleSegmentControl.ValueChanged += (sender, e) => {
				var selectedSegmentId = (sender as UISegmentedControl).SelectedSegment;

				// do something with selectedSegmentId
				if (selectedSegmentId == 0) {					
					Console.WriteLine (selectedSegmentId);	
					sampleSegmentControl.BackgroundColor = UIColor.LightGray;

				} else {
					Console.WriteLine (selectedSegmentId);
					sampleSegmentControl.BackgroundColor = UIColor.White;
				}
				;

			};
			this.View.AddSubview (sampleSegmentControl);
		}

		private void addSearchBarToView ()
		{
			sampleSearchBar = new UISearchBar (new CoreGraphics.CGRect (20, 20, this.View.Frame.Width - 50, 40));
			sampleSearchBar.SearchBarStyle = UISearchBarStyle.Prominent;

			sampleSearchBar.ShowsCancelButton = true;
			sampleSearchBar.Delegate = new SearchDelegate ();
			this.View.AddSubview (sampleSearchBar);
		}

		class SearchDelegate : UISearchBarDelegate
		{
			public override void SearchButtonClicked (UISearchBar bar)
			{
				bar.ResignFirstResponder ();
			}

			public override void CancelButtonClicked (UISearchBar bar)
			{
				bar.ResignFirstResponder ();
			}

			public override bool ShouldBeginEditing (UISearchBar searchBar)
			{
				
				return true;
			}

			public override bool ShouldEndEditing (UISearchBar searchBar)
			{
				return true;
			}

			public override bool ShouldChangeTextInRange (UISearchBar searchBar, NSRange range, string text)
			{
				Console.WriteLine (searchBar.Text);
				return true;
			}
		}

		private void addUICollectionViewToView ()
		{

			this.View.AddSubview (sampleCollectionView);

		}

		private void addUIActivityIndicatorToView ()
		{
			this.View.BackgroundColor = UIColor.DarkGray;

			sampleIndicator = new UIActivityIndicatorView ();
			sampleIndicator.Center = this.View.Center;
			sampleIndicator.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.WhiteLarge;
			//sampleIndicator.BackgroundColor = UIColor.Red;
			//sampleIndicator.TintColor = UIColor.Red;
			this.View.AddSubview (sampleIndicator);

			sampleIndicator.StartAnimating ();
			//sampleIndicator.StopAnimating ();		
		}

		private void addUIProgressViewToView ()
		{
			sampleProgressView = new UIProgressView (UIProgressViewStyle.Bar);
			sampleProgressView.Frame = new CoreGraphics.CGRect (20, 120, this.View.Frame.Width - 50, 40);
			sampleProgressView.BackgroundColor = UIColor.Brown;
			sampleProgressView.TintColor = UIColor.Red;
			this.View.AddSubview (sampleProgressView);

			sampleProgressView.SetProgress (0.5f, true);
		}

		private void addUIRefreshControlToView ()
		{
			sampleRefreshControlTableView = new UITableView ();
			sampleRefreshControlTableView.Frame = new CoreGraphics.CGRect (this.View.Frame.X, this.View.Frame.Y + 44, this.View.Frame.Width, this.View.Frame.Height);

			//Setting Table Source
			string[] refreshTableItems = new string[] { "1", "2", "3", "4", "5", "6" };
			sampleRefreshControlTableView.Source = new RefreshTableSource (refreshTableItems, this);
			Add (sampleRefreshControlTableView);
			this.View.AddSubview (sampleRefreshControlTableView);

			sampleRefreshConrtrol = new UIRefreshControl ();
			sampleRefreshConrtrol.AttributedTitle = new NSAttributedString ("Pull To Refresh",
				new UIStringAttributes () {
					ForegroundColor = UIColor.Red,
					KerningAdjustment = 3
				});
			sampleRefreshConrtrol.ValueChanged += refreshControlOnValueChanged;
			sampleRefreshControlTableView.AddSubview (sampleRefreshConrtrol);
			sampleRefreshConrtrol.Enabled = true;

		}

		public class RefreshTableSource : UITableViewSource
		{
			ViewController owner;

			string[] refreshTableItems;
			string CellIdentifier = "TableCell";

			public event EventHandler<NSIndexPath> FundRequestSelected;

			public RefreshTableSource (string[] items, ViewController owner)
			{
				refreshTableItems = items;
				this.owner = owner;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return refreshTableItems.Length;
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
				string item = refreshTableItems [indexPath.Row];

				//---- if there are no cells to reuse, create a new one
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);
				}

				cell.TextLabel.Text = item;
				cell.TextLabel.TextAlignment = UITextAlignment.Center;
				return cell;
			}

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{

				tableView.DeselectRow (indexPath, true);

				if (FundRequestSelected != null)
					FundRequestSelected (this, indexPath);
			}

		}

		private void refreshControlOnValueChanged (object sender, EventArgs e)
		{


			sampleRefreshConrtrol.AttributedTitle = new NSAttributedString ("Refreshing",
				new UIStringAttributes () {
					ForegroundColor = UIColor.Blue,
					KerningAdjustment = 5
				});
			
			var sampleTimer = NSTimer.CreateRepeatingScheduledTimer (TimeSpan.FromSeconds (5.0), delegate {

				sampleRefreshConrtrol.EndRefreshing ();		
				sampleRefreshConrtrol.Enabled = false;
			});

			if (sampleRefreshConrtrol.Enabled = false) {
				sampleTimer.Invalidate ();
			}
		}

		private void addUIStepperToView ()
		{
			sampleImageView = new UIImageView (new CGRect (10f, 150f, this.View.Frame.Width - 100, 150f));
			sampleImageView.Image = UIImage.FromFile ("Real-Estate_4.jpg");
			this.View.AddSubview (sampleImageView);

			sampleStepper = new UIStepper (new CoreGraphics.CGRect (120, 70, this.View.Frame.Width - 50, 40));
			sampleStepper.ValueChanged += sampleStepperOnValueChanged;
			sampleStepper.AutoRepeat = true;
			sampleStepper.MaximumValue = 1;
			//sampleStepper.Wraps = true;
			sampleStepper.StepValue = 1;

			this.View.AddSubview (sampleStepper);
		}

		private void sampleStepperOnValueChanged (object sender, EventArgs e)
		{			
			Console.WriteLine (sampleStepper.Value);
	
			if (sampleStepper.Value == 1) {	

				sampleImageView.Frame = new CGRect (10f, 150f, this.View.Frame.Width - 100, sampleImageView.Frame.Height * 2);
				sampleImageView.UpdateConstraintsIfNeeded ();
								
			} else { 	
				
				sampleImageView.Frame = new CGRect (10f, 150f, this.View.Frame.Width - 100, sampleImageView.Frame.Height / 2);
				sampleImageView.UpdateConstraintsIfNeeded ();
			
			}
		
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

