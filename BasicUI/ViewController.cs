using System;
using CoreGraphics;
using UIKit;
using Foundation;

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

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			//this.addUILabelToView ();
			//this.addUITextFieldToView ();
			//this.addUIViewToViewController ();
			//this.addUIButtonToView ();
			this.addUIToolBarToView ();

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
		public void addUIButtonToView()
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
		void addUIToolBarToView()
		{

			sampleToolBar1 = new UIToolbar ();
			sampleToolBar1.Frame = new CoreGraphics.CGRect (50f, 100f, 300f, 50f);

			var browserButton = new UIBarButtonItem("Browser", UIBarButtonItemStyle.Plain, null);
			var backButton = new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain, null);
			var forwardButton = new UIBarButtonItem ("Forward", UIBarButtonItemStyle.Plain, null);

			sampleToolBar1.Items = new UIBarButtonItem[] { backButton, forwardButton, browserButton };

			this.View.AddSubview (sampleToolBar1);
		
		}
		void barButtonTapped(String barButtonName)
		{
			UIAlertController okAlertController = UIAlertController.Create ("UIButton Selected",barButtonName, UIAlertControllerStyle.Alert);
			okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			this.PresentViewController (okAlertController, true, null);			
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

