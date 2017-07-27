using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp.Helpers;
using Xamarin.Forms;

namespace DemoApp.Views
{
    public partial class Money : ContentPage
    {
        public Money()
        {
            InitializeComponent();
			label1.Scale = 0;
			label2.Scale = 0;
			label3.Scale = 0;
			label4.Scale = 0;
			label5.Scale = 0;
			label6.Scale = 0;
			label7.Scale = 0;
			
        }

        protected override void OnAppearing()
        {
            Animation();
            base.OnAppearing();
        }
		private async void Animation()
		{
			await Task.Delay(App.DelaySpeed);
			
            await label1.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label2.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label3.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label4.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label5.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label6.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			await label7.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
			
		}
    }
}
