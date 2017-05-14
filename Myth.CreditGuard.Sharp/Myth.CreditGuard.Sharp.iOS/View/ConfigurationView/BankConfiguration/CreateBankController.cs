using Myth.CreditGuard.Sharp.Model.Entity;
using Myth.CreditGuard.Sharp.Service;
using System;

using UIKit;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.BankConfiguration
{
    public partial class CreateBankController : UIViewController
    {
        private BankConfigurationController _bankConfigurationController;
        public CreateBankController(BankConfigurationController bankConfigurationController) : base("CreateBankController", null)
        {
            _bankConfigurationController = bankConfigurationController;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void ConfirmButton_TouchUpInside(object sender, EventArgs e)
        {
            BankEntity bankEntity = new BankEntity()
            {
                BankName = BankNameInput.Text,
                BankAbbr = BankAbbrInput.Text
            };
            SqliteService.SqliteConnection.Insert(bankEntity);

            NavigationController.PopViewController(true);

            _bankConfigurationController.AddNewBank(bankEntity);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ConfirmButton.TouchUpInside += ConfirmButton_TouchUpInside;
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}