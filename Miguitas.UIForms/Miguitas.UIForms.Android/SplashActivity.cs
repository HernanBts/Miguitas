namespace Miguitas.UIForms.Droid
{
    using Android.App;
    using Android.Content;
    using Android.OS;

    [Activity(
        Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // Most apps have this
            base.OnCreate(bundle);
            System.Threading.Thread.Sleep(1800);
            this.StartActivity(typeof(MainActivity));

            //var intent = new Intent(this, typeof(MainActivity));
            //if (Intent.Extras != null)
            //    intent.PutExtras(Intent.Extras); // copy push info from splash to main
            //StartActivity(intent);
        }
    }

}