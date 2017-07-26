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
            SelectedMenu = new Models.Menus();
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


        private Menus selecteMenu;

        public Menus SelectedMenu
        {
            get { return selecteMenu; }
            set
            {
                selecteMenu = value;
                OnPropertyChanged();
            }
        }


        private void FillMenuItems()
        {
            try
            {
               
                MenuList = new ObservableCollection<Menus>();

              
                MenuList.Add(new Menus
                {
                    Title = "Dashboard",
                    IconSource = "",
                    TargetType = typeof(DashboardPage),
                });
                MenuList.Add(new Menus
                {

                    Title = "Report",
                    IconSource = "",
                    TargetType = typeof(Report),
                });
                MenuList.Add(new Menus
                {
                    Title = "Settings",
                    IconSource = "",
                    TargetType = typeof(Report),
                });
                MenuList.Add(new Menus
                {
                    Title = "Settings",
                    IconSource = "",
                    TargetType = typeof(Report),
                });

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
