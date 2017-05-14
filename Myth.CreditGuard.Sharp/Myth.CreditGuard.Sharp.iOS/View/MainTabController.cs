using System;

using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View
{
    public partial class MainTabController : UITabBarController
    {
        protected MainTabController(IntPtr handle): base(handle) { }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SelectedIndex = 1;
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}