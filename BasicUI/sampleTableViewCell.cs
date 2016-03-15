using System;

using Foundation;
using UIKit;

namespace BasicUI
{
	public partial class sampleTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("sampleTableViewCell");
		public static readonly UINib Nib;

		static sampleTableViewCell ()
		{
			Nib = UINib.FromName ("sampleTableViewCell", NSBundle.MainBundle);
		}

		public sampleTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
