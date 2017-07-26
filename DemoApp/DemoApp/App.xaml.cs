using DemoApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navigationPage = new NavigationPage(new Views.SplashScreenPage());
           
            MainPage = navigationPage;
           
        }

    
    }
}
