using System;

using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.CreditCardConfiguration
{
    public partial class CreateCreditCardController : UIViewController
    {
        CreditCardConfigurationController _creditCardConfigurationController;
        public CreateCreditCardController(CreditCardConfigurationController creditCardConfigurationController) : base("CreateCreditCardController", null)
        {
            _creditCardConfigurationController = creditCardConfigurationController;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CreditDueModePicker.DataSource = new CreditDueModePickerDataSource();
            CreditDueModePicker.Delegate = new CreditDueModePickerDelegate();
            var a = View;
            CreditLimitInput.EditingDidEnd += TextField_EditingDidEnd;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void TextField_EditingDidEnd(object sender, EventArgs e)
        {
            ((UITextField)sender).ResignFirstResponder();
        }

        class BankPickerDataSource : UIPickerViewDataSource
        {
            public override nint GetComponentCount(UIPickerView pickerView)
            {
                throw new NotImplementedException();
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                throw new NotImplementedException();
            }
        }

        class BankPickerDelegate : UIPickerViewDelegate
        {

        }

        class CreditDueModePickerDataSource : UIPickerViewDataSource
        {
            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 2;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return 2;
            }
        }

        class CreditDueModePickerDelegate : UIPickerViewDelegate
        {
            //public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            //{
            //    string title = "";
            //    if (component == 0)
            //    {
            //        if (row == 0)
            //        {
            //            title = "固定日期";
            //        }
            //        else
            //        {
            //            title = "倒数X日";
            //        }
            //    }
            //    else
            //    {
            //        if (row == 0)
            //        {
            //            title = "出账后X日";
            //        }
            //        else
            //        {
            //            title = "固定日期";
            //        }
            //    }
            //    return title;
            //}
            public override UIView GetView(UIPickerView pickerView, nint row, nint component, UIView view)
            {
                string title = "";
                if (component == 0)
                {
                    if (row == 0)
                    {
                        title = "固定日期";
                    }
                    else
                    {
                        title = "倒数X日";
                    }
                }
                else
                {
                    if (row == 0)
                    {
                        title = "出账后X日";
                    }
                    else
                    {
                        title = "固定日期";
                    }
                }
                UILabel uiLabel = view as UILabel;
                if(uiLabel == null)
                {
                    uiLabel = ViewUtils.CreatePickerItemView();
                }
                uiLabel.Text = title;
                return uiLabel;
            }
        }
    }
}