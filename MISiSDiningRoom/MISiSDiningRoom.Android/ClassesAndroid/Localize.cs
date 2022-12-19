using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MISiSDiningRoom.Interfacese;
[assembly: Dependency(typeof(MISiSDiningRoom.Droid.ClassesAndroid.Localize))]
//В следующем примере показано использование атрибута
//DependencyAttribute для регистрации реализации iOS интерфейса IDeviceOrientationService:
// тут аналогично 
namespace MISiSDiningRoom.Droid.ClassesAndroid
{
    internal class Localize : ILocalize
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-");
            return new System.Globalization.CultureInfo(netLanguage);
        }
    }
}