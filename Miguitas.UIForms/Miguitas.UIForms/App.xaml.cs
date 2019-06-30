namespace Miguitas.UIForms
{
    using Xamarin.Forms.Xaml;
    using Xamarin.Forms;
    using Miguitas.UIForms.Views;
    using Miguitas.UIForms.ViewModels;
    using Miguitas.Common.Helpers;
    using Newtonsoft.Json;
    using Miguitas.Common.Models;
    using System;
    using Microsoft.AppCenter;
    using Microsoft.AppCenter.Push;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        public App()
        {
            InitializeComponent();

            if (Settings.IsRemember)
            {
                var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
                if (token.Expiration > DateTime.Now)
                {
                    var mainViewModel = MainViewModel.GetInstance();
                    mainViewModel.Token = token;
                    mainViewModel.UserEmail = Settings.UserEmail;
                    mainViewModel.UserPassword = Settings.UserPassword;
                    mainViewModel.Products = new ProductsViewModel();
                    this.MainPage = new MasterPage();
                    return;
                }
            }

            MainViewModel.GetInstance().Login = new LoginViewModel();
            this.MainPage = new NavigationPage(new LoginPage());
        }


        protected override void OnStart()
        {
            if (!AppCenter.Configured)
            {
                Microsoft.AppCenter.Push.Push.PushNotificationReceived += OnPushNotificationRecieved;
            }

            // AppCenter.start after
            AppCenter.Start("android=20aa2c75-55e7-477a-94e9-5eaff9a1b6a0;" +
                              "ios={Your iOS App secret here}",

                              typeof(Microsoft.AppCenter.Push.Push));
            AppCenter.GetInstallIdAsync().ContinueWith(installId =>
            {
                System.Diagnostics.Debug.WriteLine("*****************************************************");
                System.Diagnostics.Debug.WriteLine("-----------------" + installId.Result);
                System.Diagnostics.Debug.WriteLine("*****************************************************");
            });
        }

        private void OnPushNotificationRecieved(object sender, PushNotificationReceivedEventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                Current.MainPage.DisplayAlert(e.Title, e.Message, "OK");
            });
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
