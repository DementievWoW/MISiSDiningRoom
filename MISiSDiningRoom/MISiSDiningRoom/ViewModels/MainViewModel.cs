﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MISiSDiningRoom.Classes;
using MISiSDiningRoom.Pages;
using MISiSDiningRoom.ResoursesGeneral;
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
