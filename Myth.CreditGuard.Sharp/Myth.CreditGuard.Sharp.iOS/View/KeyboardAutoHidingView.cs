using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View
{
    [Register("KeyboardAutoHidingView")]
    public class KeyboardAutoHidingView : UIControl
    {
        public KeyboardAutoHidingView(IntPtr handle):base(handle)
        {
            Initialize();
        }

        public KeyboardAutoHidingView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            //BackgroundColor = UIColor.Red;
            TouchUpInside += KeyboardAutoHidingView_TouchUpInside;
        }

        private void KeyboardAutoHidingView_TouchUpInside(object sender, EventArgs e)
        {
            this.EndEditing(true);
        }
    }
}