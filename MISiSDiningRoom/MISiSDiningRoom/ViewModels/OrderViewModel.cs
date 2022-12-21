using MISiSDiningRoom.Classes;
using MISiSDiningRoom.Interfacese;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
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

