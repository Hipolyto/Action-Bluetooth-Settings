using System;
using Android.Content;
using SampleBluetoothSettings.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppSettings))]
namespace SampleBluetoothSettings.Droid
{
    public class AppSettings : IAppSettings
    {
        public void OpenSettings()
        {
            var action = Android.Provider.Settings.ActionBluetoothSettings;
            Intent intent = new Intent(action);
            ComponentName componentName = intent.ResolveActivity(MainActivity.Instance.PackageManager);

            if (componentName != null)
            {
                MainActivity.Instance.StartActivity(intent);
            }
        }
    }
}
