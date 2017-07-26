using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Helpers;
using DemoApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        
        public DashboardPage()
        {
            InitializeComponent();
            this.BindingContext = new DashboardViewModel();
            Animation();
        }

        private async void Animation()
        {
            scrollView.Opacity = 0;
            await scrollView.FadeTo(1, 5000);
        }

        async void Handle_Scrolled(object sender, Xamarin.Forms.ScrolledEventArgs e)
		{
            await this.ColorTo(Color.FromRgb(0, 0, 0), Color.FromRgb(255, 255, 255), c => BackgroundColor = c, 5000);
		}

	}
}
