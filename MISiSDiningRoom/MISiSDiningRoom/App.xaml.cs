using MISiSDiningRoom.Interfacese;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using Xamarin.Forms;

namespace MISiSDiningRoom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Resource.Culture = DependencyService.Get<ILocalize>()
                                .GetCurrentCultureInfo();
            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
