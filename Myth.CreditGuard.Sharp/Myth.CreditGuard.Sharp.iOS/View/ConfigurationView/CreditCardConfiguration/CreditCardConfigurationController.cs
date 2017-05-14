
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.CreditCardConfiguration
{
    public partial class CreditCardConfigurationController : UITableViewController
    {
        public CreditCardConfigurationController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }


        private void OnCreditCardAdd(object sender, EventArgs e)
        {
            NavigationController.PushViewController(new CreateCreditCardController(this), true);
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add, OnCreditCardAdd);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}