// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.CreditCardConfiguration
{
    [Register ("CreateCreditCardController")]
    partial class CreateCreditCardController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView BankPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CreditCardNameInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CreditCardNumberInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CreditDueModePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CreditLimitInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper CreditLimitStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DueDayInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper DueDayStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InvoiceDayInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper InvoiceDayStepper { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BankPicker != null) {
                BankPicker.Dispose ();
                BankPicker = null;
            }

            if (CreditCardNameInput != null) {
                CreditCardNameInput.Dispose ();
                CreditCardNameInput = null;
            }

            if (CreditCardNumberInput != null) {
                CreditCardNumberInput.Dispose ();
                CreditCardNumberInput = null;
            }

            if (CreditDueModePicker != null) {
                CreditDueModePicker.Dispose ();
                CreditDueModePicker = null;
            }

            if (CreditLimitInput != null) {
                CreditLimitInput.Dispose ();
                CreditLimitInput = null;
            }

            if (CreditLimitStepper != null) {
                CreditLimitStepper.Dispose ();
                CreditLimitStepper = null;
            }

            if (DueDayInput != null) {
                DueDayInput.Dispose ();
                DueDayInput = null;
            }

            if (DueDayStepper != null) {
                DueDayStepper.Dispose ();
                DueDayStepper = null;
            }

            if (InvoiceDayInput != null) {
                InvoiceDayInput.Dispose ();
                InvoiceDayInput = null;
            }

            if (InvoiceDayStepper != null) {
                InvoiceDayStepper.Dispose ();
                InvoiceDayStepper = null;
            }
        }
    }
}