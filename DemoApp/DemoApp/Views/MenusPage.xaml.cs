using DemoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
  
    public partial class MenusPage : ContentPage
    {
        public ListView ListView { get { return LvMenuList; } }
        public MenusPage()
        {
            InitializeComponent();
            this.BindingContext = new MenuViewModel();
           
        }
    }
}
