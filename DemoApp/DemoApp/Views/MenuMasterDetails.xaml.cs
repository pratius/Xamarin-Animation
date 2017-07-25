using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMasterDetails : MasterDetailPage
    {
        public MenuMasterDetails()
        {
            InitializeComponent();
            masterMenuPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as MenuItem;
                if (item != null)
                {
                    //For Help Page Navigation should be not like master details Page.
                    if (item.RequestedPage == ApplicationActivity.HelpPage)
                    {
                        IsPresented = false;
                        await Detail.Navigation.PushCustAsync(new Pages.HelpPage());
                        masterMenuPage.ListView.SelectedItem = null;
                        return;
                    }

                    IsPresented = false;
                    await Task.Yield();
                    detailPageType = GetPageToDisplay(item.RequestedPage);
                    ShowDetailPage();
                }
            }
            catch (Exception ex)
            {
                Helper.LogException(ex, "OnItemSelected", "MainPage ");
            }

        }

        private Type GetPageToDisplay(ApplicationActivity page)
        {
            var result = typeof(HubManagementPage);
            if (Cache.GetNewCommonAppDbObject().ApplicationUser_Get().IsActive)
            {
                switch (page)
                {
                    case ApplicationActivity.HubManagementPage:
                        result = typeof(HubManagementPage);
                        break;
                    case ApplicationActivity.NotificationCentrePage:
                        result = typeof(Pages.NotificationCentre.NotificationCentrePage);
                        break;
                    case ApplicationActivity.DeviceManagementPage:
                        result = typeof(Pages.DeviceManagement.DeviceManagementPage);
                        break;
                    case ApplicationActivity.ServiceModePage:
                        result = typeof(Pages.ServiceMode.ServiceModePage);
                        break;
                    case ApplicationActivity.UsersPage:
                        result = typeof(Pages.UserAccounts.UsersPage);
                        break;
                    case ApplicationActivity.AccountSettingsPage:
                        result = typeof(Pages.UserAccounts.AccountSettingsPage);
                        break;
                    case ApplicationActivity.AboutPage:
                        result = typeof(Pages.AboutPage);
                        break;
                    case ApplicationActivity.HelpPage:
                        result = typeof(Pages.HelpPage);
                        break;
                    case ApplicationActivity.SignOutPage:
                        result = typeof(Pages.UserAccounts.SignOutPage);
                        break;
                    case ApplicationActivity.ServiceEngineerDefaultPage:
                        result = typeof(Pages.ServiceEngineer.ServiceModeSelectOptionPage);
                        break;
                    case ApplicationActivity.Sample:
                        result = typeof(SampleGauge);
                        break;
                }
            }
            else
            {
                result = typeof(Pages.UserAccounts.InActiveUserPage);
                switch (page)
                {
                    case ApplicationActivity.AccountSettingsPage:
                        result = typeof(Pages.UserAccounts.AccountSettingsPage);
                        break;
                    case ApplicationActivity.AboutPage:
                        result = typeof(Pages.AboutPage);
                        break;
                    case ApplicationActivity.HelpPage:
                        result = typeof(Pages.HelpPage);
                        break;
                    case ApplicationActivity.SignOutPage:
                        result = typeof(Pages.UserAccounts.SignOutPage);
                        break;
                }
            }

            return result;
        }
    }
}
