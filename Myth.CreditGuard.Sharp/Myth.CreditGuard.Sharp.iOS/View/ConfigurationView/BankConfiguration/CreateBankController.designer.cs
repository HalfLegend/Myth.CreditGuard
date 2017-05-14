// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.BankConfiguration
{
    [Register ("CreateBankController")]
    partial class CreateBankController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField BankAbbrInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField BankNameInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConfirmButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BankAbbrInput != null) {
                BankAbbrInput.Dispose ();
                BankAbbrInput = null;
            }

            if (BankNameInput != null) {
                BankNameInput.Dispose ();
                BankNameInput = null;
            }

            if (ConfirmButton != null) {
                ConfirmButton.Dispose ();
                ConfirmButton = null;
            }
        }
    }
}