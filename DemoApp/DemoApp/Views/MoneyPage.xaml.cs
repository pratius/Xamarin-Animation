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
    public partial class MoneyPage : ContentPage
    {
        public MoneyPage()
        {
            InitializeComponent();
            Animation();
        }


        private async void Animation()
        {
            await Task.Delay(App.DelaySpeed);
            await label1.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
            await label2.ScaleTo(1, App.AnimationSpeed, Easing.SinIn);
        }

       
    }
}
