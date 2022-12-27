
using System.Windows.Input;
using MISiSDiningRoom.Classes;
using MISiSDiningRoom.Pages;
using Xamarin.Forms;


namespace MISiSDiningRoom.ViewModes
{
    internal class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            


        }
        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        public ICommand AuthCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new AuthPage()));



    }
}
