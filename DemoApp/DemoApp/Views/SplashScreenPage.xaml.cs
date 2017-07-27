using System;
using System.Collections.Generic;
using DemoApp.Helpers;
using Xamarin.Forms;

namespace DemoApp.Views
{
    public partial class SplashScreenPage : ContentPage
    {
        public SplashScreenPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Animate.BallAnimate(this.logoImage, 50, 10, 5);
			
            await Navigation.PushAsync(new MenuMasterDetails());
        }
    }
}
