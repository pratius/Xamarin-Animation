using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoApp.Views
{
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.ReportViewModel();
        }
    }
}
