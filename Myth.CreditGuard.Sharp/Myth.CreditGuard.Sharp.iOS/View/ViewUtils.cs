using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View
{
    static class ViewUtils
    {
        public static UILabel CreatePickerItemView()
        {
            return new UILabel() { TextColor = UIColor.Purple, TextAlignment= UITextAlignment.Center};
        }
    }
}