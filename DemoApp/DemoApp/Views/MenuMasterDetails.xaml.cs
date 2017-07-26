using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
   
    public partial class MenuMasterDetails : MasterDetailPage
    {
        public MenuMasterDetails()
        {
            InitializeComponent();
            masterMenuPage.ListView.ItemSelected += ListView_ItemSelected;
            Detail = new NavigationPage(new DashboardPage());

		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as Models.Menus;
                if (item != null)
                {
                    
                  GetPageToDisplay(e.SelectedItem as Models.Menus);
                   
                }
            }
            catch (Exception ex)
            {
             
            }

        }

        private void GetPageToDisplay(Menus menu)
        {
			if (menu == null)
				return;
            if (menu.Title == "Home")
            {
                Detail = new NavigationPage(new DashboardPage());
            }
            else if (menu.Title == "Leads")
            {
                Detail = new NavigationPage(new DashboardPage());
            }
            else if (menu.Title == "Signin")
            {
                Detail = new NavigationPage(new DashboardPage());
            }
            else if (menu.Title == "Signup")
            {
                Detail = new NavigationPage(new DashboardPage());
            }
        }
    }
}
