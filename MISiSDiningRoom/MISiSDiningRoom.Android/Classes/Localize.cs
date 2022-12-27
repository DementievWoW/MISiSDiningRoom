
using MISiSDiningRoom.Interfacese;
using Xamarin.Forms;

[assembly: Dependency(typeof(MISiSDiningRoom.Droid.Classes.Localize))]
namespace MISiSDiningRoom.Droid.Classes
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