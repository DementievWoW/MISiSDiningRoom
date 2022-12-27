using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MISiSDiningRoom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
            NotAuthorizedLabel.Text = Resource.NotAuthorizedLabel;
            LoginNowLabel.Text = Resource.LoginNowLabel;
            LoginButton.Text = Resource.LoginButton;
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var auth = new OAuth1Authenticator(
                consumerKey: "20147930-06e0-4f0e-aa9f-74ea4b8f0620",
                consumerSecret: "wl.emails",
                requestTokenUrl: new Uri("https://login.live.com/oauth20_authorize.srf"),
                authorizeUrl: new Uri("https://login.live.com/oauth20_authorize.srf"),
                accessTokenUrl: new Uri("https://login.live.com/oauth20_token.srf"),
                callbackUrl: new Uri("f8cdef31-a31e-4b4a-93e4-5f571e91255a")
                )
            {
                AllowCancel = true
            };
            auth.Completed += (s, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    Account loggedInAccount = eventArgs.Account;

                }
            };
        }
    }
}