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
        public List<Pick> Picks { get; set; }
        public MainViewModel()
        {
            Picks = Pick.GetPicks();
            
        }
        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));



    }
}
