using DemoApp.Models;
using DemoApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.ViewModels
{
    public class MenuViewModel:BaseDataObject
    {
        public MenuViewModel()
        {
            FillMenuItems();
        }


        private ObservableCollection<Menus> menuList;
        /// <summary>
        /// Get and set the user menu list
        /// </summary>
        public ObservableCollection<Menus> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }


        private void FillMenuItems()
        {
            try
            {

                MenuList = new ObservableCollection<Menus>();

                MenuList.Add(new Menus
                {
                    Title = "Report",
                    IconSource = "Report_Blue",
                    TargetType = typeof(DashboardPage),

                });
                MenuList.Add(new Menus
                {
                    Title = "Money",
                    IconSource = "MoneyBag_Blue",
                    TargetType = typeof(DashboardPage),

                });
                MenuList.Add(new Menus
                {
                    Title = "Time line",
                    IconSource = "Timeline_Blue",
                    TargetType = typeof(DashboardPage),

                });
                MenuList.Add(new Menus
                {
                    Title = "Comments",
                    IconSource = "Chat_Blue",
                    TargetType = typeof(DashboardPage),

                });
                MenuList.Add(new Menus
                {
                    Title = "Connected",
                    IconSource = "USBConnected_Color",
                    TargetType = typeof(DashboardPage),

                });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
