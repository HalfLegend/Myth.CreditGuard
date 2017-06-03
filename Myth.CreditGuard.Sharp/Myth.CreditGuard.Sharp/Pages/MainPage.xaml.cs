using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace Myth.CreditGuard.Sharp.Pages
{
    public partial class MainPage : TabbedPage
    {
        readonly Page[] _tabPages = { new Overview.OverviewPage(), new Credit.CreditPage(), new Settings.SettingsPage() };

        public MainPage()
        {
            InitializeComponent();

            foreach (Page page in _tabPages)
            {
                Children.Add(new NavigationPage(page)
                {
                    Title = page.Title,
                    Icon = page.Icon
                });
            }
            SelectedItem = Children[1];
        }
    }
}
