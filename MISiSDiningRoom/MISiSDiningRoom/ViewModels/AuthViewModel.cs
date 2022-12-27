using MISiSDiningRoom.Classes;
using MISiSDiningRoom.Interfacese;
using MISiSDiningRoom.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Auth;

namespace MISiSDiningRoom.ViewModels
{
    internal class AuthViewModel : BaseViewModel
    {
        public ICommand LoginCommand => new Command(() => DependencyService.Get<IOAuthService>().Login());

        public ICommand LogoutCommand => new Command(() => DependencyService.Get<IOAuthService>().Logout());

        public ICommand BackToMainPageCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
    
}
