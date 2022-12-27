using MISiSDiningRoom.Classes;
using System.Windows.Input;
using Xamarin.Forms;

namespace MISiSDiningRoom.ViewModels
{
    internal class AuthViewModel : BaseViewModel
    {
        public ICommand BackToMainPageCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
    
}
