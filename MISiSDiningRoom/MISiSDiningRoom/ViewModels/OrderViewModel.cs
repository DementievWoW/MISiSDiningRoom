using MISiSDiningRoom.Classes;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace MISiSDiningRoom.ViewModels
{
    class OrderViewModel : BaseViewModel
    {

        public OrderViewModel()
        {
            MenuList = Pick.GetPicks();
            
        }
        

       
        public List<Pick> MenuList { get; set; }
        
        public ICommand BackToMainPageCommand =>new Command(() => Application.Current.MainPage.Navigation.PopAsync());




    }
}

