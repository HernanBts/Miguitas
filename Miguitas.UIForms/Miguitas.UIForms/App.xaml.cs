namespace Miguitas.UIForms
{
    using Xamarin.Forms.Xaml;
    using Xamarin.Forms;
    using Miguitas.UIForms.Views;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
