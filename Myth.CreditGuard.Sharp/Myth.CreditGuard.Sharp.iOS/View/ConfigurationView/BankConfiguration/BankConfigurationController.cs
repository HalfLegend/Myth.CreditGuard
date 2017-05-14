
using System;
using System.Drawing;

using Foundation;
using UIKit;
using Myth.CreditGuard.Sharp.Model.Entity;
using System.Collections.Generic;
using Myth.CreditGuard.Sharp.Service;

namespace Myth.CreditGuard.Sharp.iOS.View.ConfigurationView.BankConfiguration
{
    public partial class BankConfigurationController : UITableViewController
    {
        public BankConfigurationController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public void AddNewBank(BankEntity bankEntity)
        {
            BankConfigurationSource source = TableView.Source as BankConfigurationSource;
            source.BankEntityList.Add(bankEntity);

            TableView.InsertRows(new NSIndexPath[] { NSIndexPath.FromRowSection(source.BankEntityList.Count - 1, 0) }, UITableViewRowAnimation.Automatic);
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add, OnBankAdd);
            TableView.Source = new BankConfigurationSource();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void OnBankAdd(object sender, EventArgs e)
        {
            NavigationController.PushViewController(new CreateBankController(this), true);
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

        class BankConfigurationSource : UITableViewSource
        {
            public BankConfigurationSource()
            {
                BankEntityList.AddRange(SqliteService.SqliteConnection.Table<BankEntity>().Where(p => true));
            }
            private NSString bankCellIdentifier = new NSString("BankCell");
            public List<BankEntity> BankEntityList { get; } = new List<BankEntity>();
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                UITableViewCell uiTableViewCell = tableView.DequeueReusableCell(bankCellIdentifier, indexPath);
                uiTableViewCell.TextLabel.Text = BankEntityList[indexPath.Row].BankName;
                return uiTableViewCell;
            }

            public override nint RowsInSection(UITableView tableView, nint section)
            {
                return BankEntityList.Count;
            }
        }
    }
}