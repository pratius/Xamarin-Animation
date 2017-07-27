using DemoApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoApp
{
    public partial class App : Application
    {
        public static uint AnimationSpeed = 250;
        public static int DelaySpeed = 300;
        public App()
        {

<<<<<<< HEAD
            InitializeComponent();
            var navigationPage = new NavigationPage(new Views.SplashScreenPage());
           
            MainPage = navigationPage;
           
=======
            MainPage =new NavigationPage(new SplashScreenPage());
>>>>>>> a30c6ad... dd
        }

    
    }
}
