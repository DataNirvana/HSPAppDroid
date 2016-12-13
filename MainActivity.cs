using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using HSPApp;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace HSPApp.Droid
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    [Activity(Label = "HSPApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            

            // Set the AssetPath in the root
            AppHelper.AssetPath = "file:///android_asset/";

            AppHelper.AssemblySuffix = ".Droid";

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public override void OnBackPressed() {

            // Always override the back button? NO
            AppHelper aHelper = new AppHelper();
            bool customAction = aHelper.GoBack();
            //if (AppHelper.IsHomePage == false) {
            //AppHelper aHelper = new AppHelper();


            //} else {
            if (customAction == false) {
                base.OnBackPressed();
            }

        }

    }
}

