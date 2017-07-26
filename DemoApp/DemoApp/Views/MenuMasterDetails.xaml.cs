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
   
    public partial class MenuMasterDetails
    {
        public MenuMasterDetails()
        {
            InitializeComponent();
            masterMenuPage.ListView.ItemSelected += ListView_ItemSelected;
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new Views.DashboardPage());

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as Models.Menus;
                if (item != null)
                {

                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    masterMenuPage.ListView.SelectedItem = null;
                    IsPresented = false;

                }
            }
            catch (Exception ex)
            {
             
            }

        }
    }
}
